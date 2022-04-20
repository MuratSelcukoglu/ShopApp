using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Create(Product entity)
        {
            if (Validation(entity))
            {
                _productRepository.Create(entity);
                return true;
            }

            return false;
        }
        public async Task<Product> CreateAsync(Product entity)
        {
            await _productRepository.CreateAsync(entity);
            return entity;
        }

        public void Delete(Product entity)
        {
            // iş kuralları uygula
            _productRepository.Delete(entity);

        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepository.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productRepository.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public List<Product> GetHomePageProducts()
        {
            return _productRepository.GetHomePageProducts();
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name, page, pageSize);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public bool Update(Product entity, int[] categoryIds)
        {
            if (Validation(entity))
            {
                if (categoryIds.Length == 0)
                {
                    ErrorMessage += "Ürün için en az bir kategori seçmelisiniz.";
                    return false;
                }
                _productRepository.Update(entity, categoryIds);
                return true;
            }
            return false;
        }
        public async Task UpdateAsync(Product entityUpdate, Product entity)
        {
            entityUpdate.Name = entity.Name;
            entityUpdate.Price = entity.Price;
            entityUpdate.Description = entity.Description;

            await _productRepository.CreateAsync(entityUpdate);
        }

        public string ErrorMessage { get; set; }
        public bool Validation(Product entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Ürün ismi girmelisiniz.\n";
                isValid = false;
            }
            if (entity.Price < 0)
            {
                ErrorMessage += "Ürün fiyatı sıfırdan küçük olamaz.\n";
                isValid = false;
            }

            return isValid;
        }


    }
}