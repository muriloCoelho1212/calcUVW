using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcUVW.code;
using calcUVW.pages;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(fatorK_2), typeof(fatorK_2));
            Routing.RegisterRoute(nameof(ajuda1), typeof(ajuda1));
            Routing.RegisterRoute(nameof(fatorK_3), typeof(fatorK_3));
        }

        private bool changeTheme = false;
        private async void themeChanged_Clicked(object sender, EventArgs e)
        {
            if (changeTheme)
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
                Application.Current.Properties["tema"] = 2;
            }
            else
            {
                Application.Current.UserAppTheme = OSAppTheme.Light;
                Application.Current.Properties["tema"] = 1;
            }

            changeTheme = !changeTheme;
            await Application.Current.SavePropertiesAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void btnQuemSomos_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.uvw.com.br");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}