using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrabalhoJeffersonFonseca
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnButton1Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new TextScreen());
        }

        private void OnButton2Clicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new ImageView());
        }

        private void OnButton3Clicked(Object sender, EventArgs args)
        {
            DisplayAlert("Olá", "Sou uma mensagem!","1");
        }


    }
}
