using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListGroup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            var itemsGrouped = new List<Group>
            {
                new Group("Importantes", new List<ListItem>
                {
                    new ListItem{ Title = "Primeiro", Description = "Primeiro item" },
                    new ListItem{ Title = "Segundo", Description = "Segundo item" },
                }),
                new Group("Menos importantes", new List<ListItem>
                {
                    new ListItem{ Title = "Terceiro", Description = "Terceiro item" },
                    new ListItem{ Title = "Quarto", Description = "Quarto item" },
                })
            };

            var listView = new ListView
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Key"),
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        { TextCell.TextProperty, new Binding("Title") },
                        { TextCell.DetailProperty, new Binding("Description") },
                    }
                }
            };

            listView.ItemsSource = itemsGrouped;
            Content = listView;

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
        }
    }

    public class ListItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Group : List<ListItem>
    {
        public string Key { get; private set; }

        public Group(string key, List<ListItem> listItems)
        {
            Key = key;

            foreach (var item in listItems)
            {
                this.Add(item);
            }
        }
    }
}
