using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFRenderer
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            CustomButton button = new CustomButton
            {
                Text = "Custom Button",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill
            };

            button.Clicked += (s, a) =>
            {
                DisplayAlert("Renderizador Personalizado", "Esse botão foi renderizado em uma class específica da plataforma", "OK");
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    button
                }
            };

		}
	}
}
