using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class fatorK_2 : ContentPage
    {
        public fatorK_2()
        {
            InitializeComponent();
        }
        private async void ajuda2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajuda2(), true);
        }
    }
}