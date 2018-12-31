using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinBook.Views
{
    public class ControlsPage : ContentPage
    {
        Label eventValue;
        Label pageValue;

        public ControlsPage()
        {

            Title = "Exemplos de Constroles";

            eventValue = new Label { Text = "Valor do evento..." };
            pageValue = new Label { Text = "Valor do controle..." };

            var picker = new Picker()
            {
                Title = "Option",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var options = new List<string> { "Primeiro", "Segundo", "Terceiro", "Quarto" };
            options.ForEach(o => picker.Items.Add(o));
            picker.SelectedIndexChanged += (s, a) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };

            var datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            datePicker.DateSelected += (s, e) =>
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
            };

            var timePicker = new TimePicker
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            timePicker.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            var stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            stepper.ValueChanged += (s, e) =>
            {
                eventValue.Text = $"O valor do Stepper é {e.NewValue:F1}";
                pageValue.Text = stepper.Value.ToString();
            };

            var slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 50,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300
            };
            slider.ValueChanged += (s, e) =>
            {
                eventValue.Text = $"O valor do Slider é {e.NewValue:F1}";
                pageValue.Text = slider.Value.ToString();
            };

            var switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            switcher.Toggled += (s, e) =>
            {
                eventValue.Text = $"O valor do Switcher é {e.Value}";
                pageValue.Text = switcher.IsToggled.ToString();
            };

            var deviceTop = 0f;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    deviceTop = 20f;
                    break;
            }

            Padding = new Thickness(10, deviceTop, 10, 5);

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    eventValue,
                    pageValue,
                    picker,
                    datePicker,
                    timePicker,
                    stepper,
                    slider,
                    switcher
                }
            };
        }
    }
}