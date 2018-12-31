
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewDatePicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calendary : ContentPage
    {
        public Calendary()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateLabelCode.Text = e.NewDate.Day + "/" + e.NewDate.Month + "/" + e.NewDate.Year;
        }
    }
}