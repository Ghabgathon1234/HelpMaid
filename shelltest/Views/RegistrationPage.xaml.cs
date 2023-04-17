using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shelltest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (passw.Text != repassw.Text)
            {
                await DisplayAlert("ERROR", "Passwords didn't match", "OK");
            }
            else
            {
                await DisplayAlert("Done", "Registered Successfuly", "OK");
                await Shell.Current.GoToAsync($"//{nameof(HomeP)}");
            }
            }
    }
}