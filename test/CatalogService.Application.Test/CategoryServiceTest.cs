using Application;
using Application.Common.Interfaces;
using Core.Model;
using Infrastructure;
using TestUtility;
using Xunit.Sdk;

namespace CatalogService.Application.Test
{
    public class CategoryServiceTest
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoryServiceTest()
        {
            var _dbContext = Utility.CreateDatabaseContext();
            Utility.SeedCategories(_dbContext);
            _categoryRepository = new Repository<Category>(_dbContext);
        }
        [Fact]
        public void CategoryService_GetAll()
        {
            var allCategories = _categoryRepository.GetAll();
            Assert.True(allCategories.Count > 0);
        }

        [Fact]
        public void CategoryService_Get()
        {
            var category = _categoryRepository.Get(1);
            Assert.True(category.Id == 1);
        }

        [Fact]
        public void CategoryService_Update()
        {
            var category = _categoryRepository.Get(1);
            category.Name = "Latest Laptop";
            var updatedCategory = _categoryRepository.Update(1, category);
            Assert.True(updatedCategory.Name == "Latest Laptop");
        }

        [Fact]
        public void CategoryService_Delete()
        {
            var allCategoriesBeforeDelete = _categoryRepository.GetAll();

            var category = _categoryRepository.Get(1);
            var updatedCategory = _categoryRepository.Delete(category);

            var allCategoriesAfterDelete = _categoryRepository.GetAll();

            Assert.True(allCategoriesBeforeDelete.Count - 1 == allCategoriesAfterDelete.Count);
        }
    }
}