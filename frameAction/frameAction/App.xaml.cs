using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace frameAction
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#2296F3") };
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
