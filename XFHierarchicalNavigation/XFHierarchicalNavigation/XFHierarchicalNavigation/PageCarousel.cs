
using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class PageCarousel : CarouselPage
	{
		public PageCarousel()
		{
            Title = "Página Carrocel";

            Children.Add(new SecondPage());
            Children.Add(new ThirdPage());
            Children.Add(new FourthPage());
		}
	}
}