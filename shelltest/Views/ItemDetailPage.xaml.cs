using shelltest.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace shelltest.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}