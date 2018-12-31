using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
	public class PageTabbed : TabbedPage
	{
		public PageTabbed ()
		{
            Children.Add(new SecondPage());
            Children.Add(new ThirdPage());
            Children.Add(new FourthPage());
		}
	}
}