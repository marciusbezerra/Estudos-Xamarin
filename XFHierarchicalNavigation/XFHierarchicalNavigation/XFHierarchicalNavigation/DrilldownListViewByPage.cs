using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class DrilldownListViewByPage : ContentPage
    {
        public DrilldownListViewByPage()
        {
            Title = "Drilldown List usando ListView";

            var listView = new ListView
            {
                ItemsSource = new ListItemPage[]
                {
                    new ListItemPage{ Title = "Terceira página", PageType = typeof(ThirdPage)  },
                    new ListItemPage{ Title = "Quarta página", PageType = typeof(FourthPage)  },
                }
            };
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, nameof(ListItemPage.Title));

            listView.ItemTapped += async (s, a) =>
            {
                if (!(a.Item is ListItemPage item)) return;
                var page = (Page)Activator.CreateInstance(item.PageType);
                await Navigation.PushAsync(page);
                listView.SelectedItem = null;
            };

            Content = listView;
        }
    }

    public class ListItemPage
    {
        public string Title { get; set; }
        public Type PageType { get; set; }
    }
}