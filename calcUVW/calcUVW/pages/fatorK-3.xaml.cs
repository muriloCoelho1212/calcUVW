using calcUVW.code;
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
	public partial class fatorK_3 : ContentPage
	{
		public fatorK_3 ()
		{
			InitializeComponent ();
		}

        private async void Calcular_Clicked(object sender, EventArgs e)
        {
            double Lv = varFatorK.Lv;
            double Espv = varFatorK.Espv;
            try
            {
                resultFatorK.Text = "";
                if(entCompBlank.Text == null || entAltA.Text == null || entAltB.Text == null || entRaioDobra.Text == null || entAng1.Text == null || entAng2.Text == null)
                {
                    await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
                }
                else
                {
                    double Cv = Convert.ToDouble(entCompBlank.Text);
                    double Av = Convert.ToDouble(entAltA.Text);
                    double Bv = Convert.ToDouble(entAltB.Text);
                    double Rv = Convert.ToDouble(entRaioDobra.Text);
                    double a1 = Convert.ToDouble(entAng1.Text);
                    double a2 = Convert.ToDouble(entAng2.Text);
                    if(Cv <= 0 || Av <= 0 || Bv <= 0 || Rv <= 0 || a1 <= 0 || a2 <= 0)
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
                        double Kr1;
                        double atotal;

                        a1 = 180 - a1;
                        a2 = 180 - a2;
                        atotal = a1 + a2;

                        lla = Av;
                        llb = Bv;
                        llc = Cv;

                        blankraiototal = Lv - lla - llb - llc;
                        blank1raio = (blankraiototal * (a1 / atotal));

                        Kr1 = ((((blank1raio / (a1 / 360)) / piv) / 2) - Rv) / Espv;

                        if(Kr1 <= 0)
                        {
                            resultFatorK.Text = "Impossível";
                        }
                        else
                        {
                            resultFatorK.Text = Kr1.ToString("N5");
                        }
                    }
                }
            }catch(FormatException)
            {
                await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajuda3(), true);
        }
    }
}