using calcUVW.pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new fatorK_3();
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
