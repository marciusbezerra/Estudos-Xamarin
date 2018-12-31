using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Title = "Segunda página";

            var homeLabel = new Label
            {
                Text = "Segunda página",
                FontSize = 40
            };

            var alertButton = new Button { Text = "Mostrar alerta!" };
            alertButton.Clicked += async (s, a) => await DisplayAlert("Alerta!", "Exibindo alerta!", "OK");

            var actionSheetButton = new Button { Text = "Mostrar ActionSheet!" };
            actionSheetButton.Clicked += async (s, a) =>
            {
                var action = await DisplayActionSheet("Opções", "Cancelar", null, "Aqui", "Ali", "Em qualquer lugar");
                await DisplayAlert("Ação!", $"A ação selecionada: {action}", "OK");
            };

            var layout = new StackLayout
            {
                Children =
                {
                    homeLabel, alertButton, actionSheetButton
                }
            };

            Content = layout;

        }
    }
}