
using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class PageMasterDetail : MasterDetailPage
    {
        public PageMasterDetail()
        {
            Title = "Página MasterDetail";

            var myPageNames = new[] { "Segunda  página", "Terceira página", "Quarta página" };

            var listView = new ListView
            {
                ItemsSource = myPageNames
            };

            Master = new ContentPage
            {
                Title = "Opções",
                Content = listView,
                //Icon = "humburger.png"
            };

            listView.ItemTapped += (s, a) =>
            {
                ContentPage gotoPage;
                switch (a.Item.ToString())
                {
                    case "Segunda  página":
                        gotoPage = new SecondPage();
                        break;
                    case "Terceira página":
                        gotoPage = new ThirdPage();
                        break;
                    case "Quarta página":
                        gotoPage = new FourthPage();
                        break;
                    default:
                        gotoPage = new HomePage();
                        break;
                }

                Detail = new NavigationPage(gotoPage);
                ((ListView)s).SelectedItem = null;
                IsPresented = false;
            };

            Detail = new NavigationPage(new HomePage());
        }
    }
}