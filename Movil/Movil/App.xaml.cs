using Movil.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    public partial class App : Application
    {
        public App()
        {
            // Licencia
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/ V1NHaF5cXmVCf1JpR2dGfV5yd0VHal 1RTndYUiweQnxTdEZiWH5ZcHVURmFb UkNwXw==");
            
            InitializeComponent();

            //MainPage = new NavigationPage(new Dashboard());
            MainPage = new NavigationPage(new LoginUI());
            //MainPage = new MainPage();
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
    }
}
