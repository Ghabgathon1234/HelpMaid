using shelltest.ViewModels;
using shelltest.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace shelltest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(Newsp), typeof(Newsp));
        }

       
    }
}
