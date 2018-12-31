using SearchPage.Models;
using System.Collections.ObjectModel;

namespace SearchPage.Services
{
    public class CategoryService
    {
        private ObservableCollection<Category> Categories = new ObservableCollection<Category>();

        public ObservableCollection<Category> GetCategories()
        {
            Categories.Add(new Category() { Id = 1, Name = "Equipamentos" });
            Categories.Add(new Category() { Id = 2, Name = "Acessórios" });
            Categories.Add(new Category() { Id = 3, Name = "Notebooks" });
            Categories.Add(new Category() { Id = 4, Name = "Impressoras" });
            Categories.Add(new Category() { Id = 5, Name = "SmartPhones" });
            Categories.Add(new Category() { Id = 6, Name = "Tablets" });
            Categories.Add(new Category() { Id = 7, Name = "Toners" });
            Categories.Add(new Category() { Id = 8, Name = "TVs" });
            return Categories;
        }

        public void Add(Category category)
        {
            Categories.Add(category);
        }
    }
}
