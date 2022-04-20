using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.EmailServices
{
    public interface IEmailSender
    {
        // smtp =>gmail, hotmail
        // api => sendgrid

        Task SendEmail(string email, string subject, string HtmlMessage);

    }
}