
using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class FourthPage : ContentPage
	{
		public FourthPage ()
		{
            Title = "Quarta página";
            Content = new StackLayout {
				Children = {
                    new Label {
                        Text = "Quarta página!",
                        FontSize = 40,
                        HorizontalOptions = LayoutOptions.Center
                    }
                }
			};
		}
	}
}