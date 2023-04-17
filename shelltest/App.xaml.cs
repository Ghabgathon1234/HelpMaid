using shelltest.Services;
using shelltest.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace shelltest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void Application_PageAppearing(object sender, Page e)
        {

        }
    }
}
