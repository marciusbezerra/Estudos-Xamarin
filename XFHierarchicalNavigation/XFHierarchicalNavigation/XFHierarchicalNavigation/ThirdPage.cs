
using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class ThirdPage : ContentPage
	{
		public ThirdPage ()
		{
            Title = "Terceira página";
            Content = new StackLayout {
                Children = {
                    new Label {
                        Text = "Terceira página!",
                        FontSize = 40,
                        HorizontalOptions = LayoutOptions.Center
                    }
				}
			};
		}
	}
}