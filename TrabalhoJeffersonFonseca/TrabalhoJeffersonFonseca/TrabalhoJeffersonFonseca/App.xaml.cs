using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrabalhoJeffersonFonseca
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            MainPage.DisplayAlert("Tchau!","1","2");
        }

        protected override void OnResume()
        {
            MainPage.DisplayAlert("Ola! de novo","1","2");

        }

    }
}
