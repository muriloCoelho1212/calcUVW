using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcUVW.pages;
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
        }

        private void Tema_Clicked(object sender, EventArgs e)
        {

        }
    }
}