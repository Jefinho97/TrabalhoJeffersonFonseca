using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabalhoJeffersonFonseca
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextScreen : ContentPage
	{
		public TextScreen ()
		{
			InitializeComponent ();

            BackgroundColor = Color.FromHex(RandomColor());
        }
        private string RandomColor()
        {
            var random = new Random();
            return String.Format("#{0:x6}", random.Next(0x1000000));
        }
    }
}