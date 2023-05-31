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

        private void raCalc()
        {
            double De = Convert.ToDouble(DeEntry.Text);
            double AE = Convert.ToDouble(AEEntry.Text);
            double Hc;
            double Ra;
            double R;

            // identifica se o Windows esta usando ponto ou virgula

            // Retorna 0 se for ponto
            // Retorna 1 se for vírgula

            R = De / 2;

            if (De >= AE)
            {
                Hc = R - Math.Pow((Math.Pow(R, 2) - Math.Pow((AE / 2), 2)), 0.5);

                Ra = (Hc / 4) * 1000;

                if (Ra > 63)
                    Anali.Text += "Ressaltos";
                if (Ra < 8.3)
                    Anali.Text += "Superfície aspera";
                if (Ra < 6.3)
                    Anali.Text += "Desbastado";
                if (Ra < 4.8)
                    Anali.Text += "Alisado grosso";
                if (Ra < 3.2)
                    Anali.Text += "Alisado";
                if (Ra < 1.6)
                    Anali.Text += "Alisado fino";
                if (Ra < 0.8)
                    Anali.Text += "Retificado grosso";
                if (Ra < 0.6)
                    Anali.Text += "Retificado";
                if (Ra < 0.4)
                    Anali.Text += "Retificado fino";

                Hcvalor.Text += Hc.ToString("N5");
                Ravalor.Text += Ra.ToString("N3");

                DeEntry.Text = "";
                AEEntry.Text = "";
            }
            else
            {
                Hcvalor.Text += "Impossível";
                Ravalor.Text += "Impossível";
                Anali.Text += "Impossível";
            }
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
            Hcvalor.Text = Hcvalor.Text.Substring(0, 18);
            Ravalor.Text = Ravalor.Text.Substring(0, 20);
            Anali.Text = Anali.Text.Substring(0, 20);
            raCalc();
        }

     
    }
}