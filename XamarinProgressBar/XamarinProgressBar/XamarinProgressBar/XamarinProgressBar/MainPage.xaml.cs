using System;
using Xamarin.Forms;

namespace XamarinProgressBar
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void btnIniciarClicked(object sender, EventArgs e)
        {
            await BarraProgresso.ProgressTo(0.9, 250, Easing.Linear);
        }

    }
}
