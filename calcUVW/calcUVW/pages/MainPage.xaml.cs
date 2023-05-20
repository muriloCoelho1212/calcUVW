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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void changeColor_Released(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundColor = Color.FromHex("#0E76BC");
        }

        private void changeColor_Pressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackgroundColor = Color.FromHex("#C4161C");
        }

        private async void Fatork_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//fatorK_1");
        }

        private async void calotaesf_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//CalEsf");
        }

        private async void rafres_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RaFresamento");
        }
    }
}