using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinBook.Models;
using XamarinBook.Views;

namespace XamarinBook.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
	{
        public ItemsPage()
        {
            InitializeComponent();
        }

        private async void ControlsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ControlsPage());
        }
    }
}