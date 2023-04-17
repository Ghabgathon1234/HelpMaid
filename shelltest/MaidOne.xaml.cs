using shelltest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shelltest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaidOne : ContentPage
	{
		public MaidOne ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Leena());
        }
    }
}