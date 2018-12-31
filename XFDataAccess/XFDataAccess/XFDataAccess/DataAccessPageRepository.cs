
using System.Linq;
using Xamarin.Forms;
using XFDataAccess.Models;

namespace XFDataAccess
{
    public class DataAccessPageRepository : ContentPage
    {
        public DataAccessPageRepository()
        {
            var label = new Label { Text = "Banco de dados criado usando SQLite.NET\n" };
            label.Text += "Usando uma repositório avançado";

            App.Repository.DeleteAllItems();

            var item = new Item { Name = "First", Description = "Esse é o primeiro item!" };
            App.Repository.SaveItem(item);

            var firstItem = App.Repository.GetFirstItems();
            label.Text += firstItem.First().Name + " foi adicionado!\n\n";

            var id = 1;
            item = App.Repository.GetItem(id);
            label.Text += item.Name + " com ID " + item.Id + "\n\n";

            App.Repository.DeleteItem(id);
            label.Text += "Item com ID " + id + " foi deletado!\n\n";

            item = new Item { Name = "First", Description = "Esse é o primeiro item" };
            App.Repository.SaveItem(item);
            item = new Item { Name = "Second", Description = "Esse é o segundo item" };
            App.Repository.SaveItem(item);
            item = new Item { Name = "Third", Description = "Esse é o terceiro item" };
            App.Repository.SaveItem(item);

            var items = App.Repository.GetItems();
            foreach (var i in items)
            {
                label.Text += i.Name + " " + i.Description + "\n";
            }

            label.Text = "\nOps! Editando item!";

            item.Description = "Esse é o último item!";
            App.Repository.SaveItem(item);

            id = 4;
            item = App.Repository.GetItem(id);
            label.Text += item.Name + " " + item.Description + "\n";

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = new StackLayout
            {
                Children = { label }
            };
        }
    }
}