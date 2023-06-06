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
    public partial class RaFresamento : ContentPage
    {
        private async void ajudaRA_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajudaRA(), true);
        }

        public RaFresamento()
        {
            InitializeComponent();
        }
        private async void calcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                resultAltCrista.Text = "";
                resultRA.Text = "";
                resultTipoSup.Text = "";
                if(entFerramenta.Text == null || EntPassoLateral.Text == null)
                {
                    await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
                }
                else
                {
                    double De = Convert.ToDouble(entFerramenta.Text);
                    double AE = Convert.ToDouble(EntPassoLateral.Text);
                    if(De <= 0 ||  AE <= 0)
                    {
                        await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
                    }
                    else
                    {
                        double Hc;
                        double Ra;
                        double R;

                        R = De / 2;

                        if (De >= AE)
                        {
                            Hc = R - Math.Pow((Math.Pow(R, 2) - Math.Pow((AE / 2), 2)), 0.5);

                            Ra = (Hc / 4) * 1000;

                            if (Ra > 63)
                            {
                                resultTipoSup.Text = "Ressaltos";
                            }
                            else if (Ra > 6.3 && Ra < 63)
                            {
                                resultTipoSup.Text = "Superfície aspera";
                            }
                            else if (Ra > 4.8 && Ra < 6.3)
                            {
                                resultTipoSup.Text = "Desbastado";
                            }
                            else if (Ra > 3.2 && Ra < 4.8)
                            {
                                resultTipoSup.Text = "Alisado grosso";
                            }
                            else if (Ra > 1.6 && Ra < 3.2)
                            {
                                resultTipoSup.Text = "Alisado";
                            }
                            else if (Ra > 0.8 && Ra < 1.6)
                            {
                                resultTipoSup.Text = "Alisado fino";
                            }
                            else if (Ra > 0.6 && Ra < 0.8)
                            {
                                resultTipoSup.Text = "Retificado grosso";
                            }
                            else if (Ra > 0.4 && Ra < 0.6)
                            {
                                resultTipoSup.Text = "Retificado";
                            }
                            else if (Ra > 0 && Ra < 0.4)
                            {
                                resultTipoSup.Text = "Retificado fino";
                            }

                            resultAltCrista.Text = Hc.ToString("N5");
                            resultRA.Text = Ra.ToString("N3");
                        }
                        else
                        {
                            resultAltCrista.Text = "Impossível";
                            resultRA.Text = "Impossível";
                            resultTipoSup.Text = "Impossível";
                        }
                    }
                }
            }
            catch(FormatException)
            {
                await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
            }
        }
    }
}