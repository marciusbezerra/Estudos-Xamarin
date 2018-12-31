
using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class HomePage : ContentPage
	{
        Button homeButton;
        Button drilldownListViewButton;
        Button drilldownTableViewButton;
        Button pageMasterDetailButton;
        Button pageCarouselButton;
        Button pageTabbedButton;

        public HomePage()
        {
            Title = "Navegação Hierarquica";

            ToolbarItems.Clear();
            ToolbarItems.Add(new ToolbarItem {
                Text = "Home Page",
                Order  = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new HomePage() ))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Segunda página",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new SecondPage()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Drilldown ListView",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new DrilldownListViewByPage()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Drilldown TableView",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new DrilldownTableViewByPage()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Página Master Detail",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushModalAsync(new PageMasterDetail()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Página com Tabs",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new PageTabbed()))
            });
            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Página Carousel",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(async () => await Navigation.PushAsync(new PageCarousel()))
            });

            var homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };

            homeButton = new Button
            {
                Text = "Ir para segunda página"
            };

            homeButton.Clicked += async (s, a) => await Navigation.PushAsync(new SecondPage());

            drilldownListViewButton = new Button
            {
                Text = "Drilldown ListView"
            };

            drilldownListViewButton.Clicked += async (s, a) => await Navigation.PushAsync(new DrilldownListViewByPage());

            drilldownTableViewButton = new Button
            {
                Text = "Drilldown TableView"
            };

            drilldownTableViewButton.Clicked += async (s, a) => await Navigation.PushAsync(new DrilldownTableViewByPage());

            pageMasterDetailButton = new Button
            {
                Text = "Página Master Detail"
            };

            pageMasterDetailButton.Clicked += async (s, a) => await Navigation.PushModalAsync(new PageMasterDetail());

            pageTabbedButton = new Button
            {
                Text = "Página com Tabs"
            };

            pageTabbedButton.Clicked += async (s, a) => await Navigation.PushAsync(new PageTabbed());

            pageCarouselButton = new Button
            {
                Text = "Página Carousel"
            };

            pageCarouselButton.Clicked += async (s, a) => await Navigation.PushAsync(new PageCarousel());

            Content = new StackLayout
            {
                Children = {
                    homeLabel,
                    homeButton,
                    drilldownListViewButton,
                    drilldownTableViewButton,
                    pageMasterDetailButton,
                    pageTabbedButton,
                    pageCarouselButton,
                }
            };
        }
    }
}