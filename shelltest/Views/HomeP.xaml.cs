using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shelltest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeP : ContentPage
	{
		public HomeP ()
		{
			InitializeComponent ();
		}

        private async void MaidB_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MaidOne());

        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Login")
            {
                await Navigation.PushAsync(new LoginPage());
                (sender as Button).Text = "Logout";
            }
            else
            {
                (sender as Button).Text = "Login";
                await Navigation.PushAsync(new LoginPage());
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            if ((sender as ToolbarItem).Text == "Logout")
            {
                (sender as ToolbarItem).Text = "Login";
            }
            else
            {
                
                (sender as ToolbarItem).Text = "Logout";
                await Navigation.PushAsync(new LoginPage());
            }
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DriverOne());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheffOne());
        }

        private async void MaidF_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TempM());
        }

        private async void ImageButton_Clickedd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TempD());
        }

        private async void ImageButton_Clickeddd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TempC());
        }
    }
}