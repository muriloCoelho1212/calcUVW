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
    public partial class CalEsf : ContentPage
    {
        public CalEsf()
        {
            InitializeComponent();
        }
        private async void calcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                resultDiametro.Text = "";
                resultCorrecaoRPM.Text = "";
                if (entFresa.Text == null || entProfCorte.Text == null || entRPM.Text == null)
                {
                    await DisplayAlert("Campos vazios", "Preencha os campos vazios para continuar", "Ok");
                }
                else
                {
                    double De = Convert.ToDouble(entFresa.Text);
                    double ap = Convert.ToDouble(entProfCorte.Text);
                    double RPM = Convert.ToDouble(entRPM.Text);
                    if (De <= 0 || ap <= 0 || RPM <= 0)
                    {
                        await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
                    }
                    else
                    {
                        double NRPM;
                        double R;
                        double vc;
                        double D;

                        R = De / 2;

                        if (ap < R)
                        {
                            vc = RPM * De * 3.14159265 / 1000;

                            D = 2 * Math.Pow((Math.Pow(R, 2) - Math.Pow((R - ap), 2)), 0.5);

                            NRPM = vc * 1000 / (D * 3.141592653);

                            resultDiametro.Text = D.ToString("N3");
                            resultCorrecaoRPM.Text = NRPM.ToString("N0");
                        }
                        else
                        {
                            resultDiametro.Text = De.ToString();
                            resultCorrecaoRPM.Text = Convert.ToDouble(entRPM.Text).ToString();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                await DisplayAlert("Valor inválido", "Preencha os campos com valores válidos", "Ok");
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajudaCAL(), true);
        }
    }
}