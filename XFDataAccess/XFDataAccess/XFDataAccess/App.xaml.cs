using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFDataAccess
{
    public partial class App : Application
    {
        private static ItemRepository repository;

        public static ItemRepository Repository
        {
            get
            {
                if (repository == null)
                {
                    repository = new ItemRepository();
                }
                return repository;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
