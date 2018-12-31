using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WFAdoNet
{
	public class ConnectionPage : ContentPage
	{
		public ConnectionPage ()
		{
            var dbName = "ItemsSQLite.db3";

#if __IOS__
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            folder = Path.Combine(folder, "..", "Library");
            var databasePath = Path.Combine(folder, dbName);
#else
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databasePath = Path.Combine(folder, dbName);
#endif

            SQLite


            Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}