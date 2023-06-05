using calcUVW.pages;
using System;
using System.Collections.Generic;
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

            try
            {
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
            }catch(KeyNotFoundException)
            {
                // tratando exceção de key nao encontrada no dicionario das properties
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
