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

        private bool changeTheme = true;

        private void themeChanged_Toggled(object sender, EventArgs e)
        {
            if (changeTheme)
            {
                App.Current.UserAppTheme = OSAppTheme.Dark;
            }
            else
            {
                App.Current.UserAppTheme = OSAppTheme.Light;
            }

            changeTheme = !changeTheme;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}