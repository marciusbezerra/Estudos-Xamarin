using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsExample
{
    public class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            var labelLarge = new Label
            {
                Text = "Label",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.Center
            };

            var smallLabel = new Label
            {
                Text = "Este controle é ideal para\n" +
                    "exibir uma ou mais\n" +
                    "linhas de texto,",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var button = new Button
            {
                Text = "Click Me",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
            };

            button.Clicked += (s, a) =>
            {
                button.Text = "Cliked!";
            };

            var entry = new Entry
            {
                Placeholder = "Username",
                VerticalOptions = LayoutOptions.Center,
                Keyboard = Keyboard.Text
            };

            var boxView = new BoxView
            {
                Color = Color.Red,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Fill
            };

            var image = new Image
            {
                Source = "gostosa.jpg",
                Aspect = Aspect.AspectFit,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Fill
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) =>
            {
                image.Opacity = .5;
                await Task.Delay(200);
                image.Opacity = 1;
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);

            var stackLayout = new StackLayout
            {
                Children =
                {
                    labelLarge,
                    smallLabel,
                    button,
                    entry,
                    boxView,
                    image
                },
                HeightRequest = 1500
            };

            var scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout
            };

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = scrollView;
        }
    }
}