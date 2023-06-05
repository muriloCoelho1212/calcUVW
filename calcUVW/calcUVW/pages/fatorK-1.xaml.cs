using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calcUVW.code;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calcUVW.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class fatorK_1 : ContentPage
    {
        public fatorK_1()
        {
            InitializeComponent();
        }

        private async void ajuda_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ajuda1");
        }

        private async void btnProxEtapa_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(compBlank.Text == null || espessChapa.Text == null)
                {
                    await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
                }
                else
                {
                    varFatorK.Lv = Convert.ToDouble(compBlank.Text);
                    varFatorK.Espv = Convert.ToDouble(espessChapa.Text);

                    if(varFatorK.Lv <= 0 || varFatorK.Espv <= 0)
                    {
                        await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
                    }
                    else
                    {
                        if (angRandom.IsChecked == true)
                        {
                            await Shell.Current.GoToAsync("fatorK_3");
                        }
                        else
                        {
                            await Shell.Current.GoToAsync("fatorK_2");
                        }
                    }

                }
            }catch(FormatException)
            {
                await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
            }
        }
    }
}