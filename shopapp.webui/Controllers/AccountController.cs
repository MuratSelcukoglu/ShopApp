using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.webui.EmailServices;
using shopapp.webui.Extension;
using shopapp.webui.Identity;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;
        private ICartService _cartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _cartService = cartService;
        }
        // [AllowAnonymous]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl,
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // var user = await _userManager.FindByNameAsync(model.UserName);
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu Kullanıcı Adı ile daha önce hesap oluşturulmamış.");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Lütfen email hesabınıza gelen link ile üyeliğinizi onaylayınız.");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Girilen kullanıcı adı veya parola yanlış.");
            return View(model);
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                // generate tooken
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                });

                //email
                await _emailSender.SendEmail(model.Email, "Hesabınızı Onaylayınız", $"Lütfen email hesabınız onaylamak için linke <a href='https://localhost:5001{url}'>tıklayınız.</a>");

                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "Bilinmeyen hata oldu lütfen tekrar deneyiniz.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage()
            {
                Title = "Oturum kapatıldı.",
                Message = "Hesabınız güvenli bir şekilde kapatıldı.",
                AlertType = "warning",
            });
            return Redirect("~/");
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage()
                {
                    Title = "Geçersiz token",
                    Message = "Geçersiz token",
                    AlertType = "danger",
                });

                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    // cart objesini oluştur.
                    _cartService.InitializeCart(user.Id);
                    TempData.Put("message", new AlertMessage()
                    {
                        Title = "Hesabınız onaylandı",
                        Message = "Hesabınız onaylandı",
                        AlertType = "success",
                    });
                    return View();
                }
            }
            TempData.Put("message", new AlertMessage()
            {
                Title = "Hesabınız onaylanmadı",
                Message = "Hesabınız onaylanmadı",
                AlertType = "warning",
            });
            return View();
        }
        // [AllowAnonymous]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            // generate tooken
            var url = Url.Action("ResetPasword", "Account", new
            {
                userId = user.Id,
                token = code
            });

            //email
            await _emailSender.SendEmail(Email, "Reset Password", $"Parolanızı yenilemek için linke <a href='https://localhost:5001{url}'>tıklayınız.</a>");

            return View();
        }
        public IActionResult ResetPasword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var model = new ResetPaswordModel { Token = token };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPasword(ResetPaswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }


    }
}