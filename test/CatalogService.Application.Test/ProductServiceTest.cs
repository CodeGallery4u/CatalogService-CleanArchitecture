using Application.Common.Interfaces;
using Application;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUtility;

namespace CatalogService.Application.Test
{
    public class ProductServiceTest
    {
        private readonly IRepository<Product> _productRepository;
        public ProductServiceTest()
        {
            var _dbContext = Utility.CreateDatabaseContext();
            Utility.SeedProduct(_dbContext);
            _productRepository = new Repository<Product>(_dbContext);
        }

        [Fact]
        public void ProductServiceTest_Get()
        {
            var product = _productRepository.Get(1);
            Assert.True(product.Id ==  1);
        }

        [Fact]
        public void ProductServiceTest_GetAll()
        {
            var allProduct = _productRepository.GetAll();
            Assert.True(allProduct.Count > 0);
        }

        [Fact]
        public void ProductService_Update()
        {
            var product = _productRepository.Get(1);
            product.Name = "iPhone";
            var updatedCategory = _productRepository.Update(1, product);
            Assert.True(updatedCategory.Name == "iPhone");
        }

        [Fact]
        public void ProductService_Delete()
        {
            var allProductsBeforeDelete = _productRepository.GetAll(); ;

            var product = _productRepository.Get(1);
            _productRepository.Delete(product);

            var allProductsAfterDelete = _productRepository.GetAll();

            Assert.True(allProductsBeforeDelete.Count - 1 == allProductsAfterDelete.Count);
        }
    }
}
