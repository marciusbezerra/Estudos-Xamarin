using SearchPage.Models;
using SearchPage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        private Label Name;
        private Label Value;
        private IEnumerable<Category> items;
        CategoryService CategoryService = new CategoryService();

        public CategoryPage(Label categoryName, Label categoryId)
        {
            InitializeComponent();
            this.items = CategoryService.GetCategories();
            this.Value = categoryId;
            this.Name = categoryName;
        }

        private async void lvCategories_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem as Category;
            this.Value.Text = item.Id.ToString();
            this.Name.Text = item.Name;
            await Navigation.PopAsync();
        }

        private void SearchCategoryEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvCategories.BeginRefresh();
            lvCategories.ItemsSource = string.IsNullOrWhiteSpace(SearchCategoryEntry.Text) ?
                items :
                items.Where(i => i.Name.Contains(SearchCategoryEntry.Text));
            lvCategories.EndRefresh();
        }
    }
}