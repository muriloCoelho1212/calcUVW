using calcUVW.pages;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            if ((int)Current.Properties["tema"] == 2)
            {
                Current.UserAppTheme = OSAppTheme.Dark;
            }
            else if ((int)Current.Properties["tema"] == 1)
            {
                Current.UserAppTheme = OSAppTheme.Light;
            }
            else
            {
                Current.UserAppTheme = OSAppTheme.Unspecified;
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
