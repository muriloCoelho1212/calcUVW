using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using calcUVW.code;

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

        private async void Calcular_Clicked(object sender, EventArgs e)
        {
            double Lv = varFatorK.Lv;
            double Espv = varFatorK.Espv;
            try
            {
                result.Text = "";
                if(C.Text == null || ladoA.Text == null || ladoB.Text == null || raio_dobra.Text == null)
                {
                    await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
                }
                else
                {
                    double Cv = Convert.ToDouble(C.Text);
                    double Av = Convert.ToDouble(ladoA.Text);
                    double Bv = Convert.ToDouble(ladoB.Text);
                    double Rv = Convert.ToDouble(raio_dobra.Text);
                    if(Cv <= 0 || Av <= 0 || Bv <= 0 || Rv <= 0)
                    {
                        await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
                    }
                    else
                    {
                        double piv = 3.141592653;
                        double lla;
                        double llb;
                        double llc;
                        double blankraiototal;
                        double blank1raio;
                        double K;

                        lla = Av - Espv - Rv;
                        llb = Bv - Espv - Rv;
                        llc = Cv - Espv - Espv - Rv - Rv;

                        blankraiototal = Lv - lla - llb - llc;
                        blank1raio = blankraiototal / 2;

                        K = (((blank1raio * 2) / piv) - Rv) / Espv;

                        if (K <= 0)
                        {
                            result.Text = "Impossível";
                        }
                        else
                        {
                            result.Text = K.ToString("N5");
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