using System.Collections.Generic;

using Xamarin.Forms;

namespace Controls
{
    public class ControlsPage : ContentPage
    {

        Label eventValue;
        Label pageValue;

        public ControlsPage()
        {
            eventValue = new Label();
            eventValue.Text = "eventValue";

            pageValue = new Label();
            pageValue.Text = "pageValue";

            var picker = new Picker();
            picker.Title = "Option";
            picker.VerticalOptions = LayoutOptions.CenterAndExpand;
            var options = new List<string>() { "First", "Second", "Third", "Fourth" };

            foreach (var option in options)
            {
                picker.Items.Add(option);
            }

            picker.SelectedIndexChanged += (s, a) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };

            var datePicker = new DatePicker();
            datePicker.Format = "D";
            datePicker.VerticalOptions = LayoutOptions.CenterAndExpand;

            datePicker.DateSelected += (s, e) =>
             {
                 eventValue.Text = e.NewDate.ToString();
                 pageValue.Text = datePicker.Date.ToString();
             };

            var timePicker = new TimePicker();
            timePicker.Format = "T";
            timePicker.VerticalOptions = LayoutOptions.CenterAndExpand;

            timePicker.PropertyChanged += (s, e) => 
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            var stepper = new Stepper();
            stepper.Minimum = 0;
            stepper.Maximum = 10;
            stepper.Increment = 1;
            stepper.HorizontalOptions = LayoutOptions.Center;
            stepper.VerticalOptions = LayoutOptions.CenterAndExpand;

            stepper.ValueChanged += (s, e) =>
            {
                eventValue.Text = $"Stepper value is {e.NewValue:f1}";
                pageValue.Text = stepper.Value.ToString();
            };

            var slider = new Slider();
            slider.Minimum = 0;
            slider.Maximum = 100;
            slider.Value = 50;
            slider.VerticalOptions = LayoutOptions.CenterAndExpand;
            slider.WidthRequest = 300;

            slider.ValueChanged += (s, e) =>
            {
                eventValue.Text = $"Slider value is {e.NewValue.ToString()}";
                pageValue.Text = slider.Value.ToString();
            };

            var switcher = new Switch();
            switcher.HorizontalOptions = LayoutOptions.Center;
            switcher.VerticalOptions = LayoutOptions.CenterAndExpand;

            switcher.Toggled += (s, e) =>
            {
                eventValue.Text = $"Switch is now {e.Value}";
                pageValue.Text = switcher.IsToggled.ToString();
            };

            this.Padding = new Thickness(10, 0, Device.OnPlatform(20, 0, 0), 5);


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