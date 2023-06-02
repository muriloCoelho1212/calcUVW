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

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            double Lv = varFatorK.Lv;
            double Espv = varFatorK.Espv;
            double Cv = Convert.ToDouble(C.Text);
            double Av = Convert.ToDouble(ladoA.Text);
            double Bv = Convert.ToDouble(ladoB.Text);
            double Rv = Convert.ToDouble(raio_dobra.Text);
            double a1 = Convert.ToDouble(ent_ang1.Text);
            double a2 = Convert.ToDouble(ent_ang2.Text);
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

            result.Text = Convert.ToString(Kr1);
            result.Text = result.Text.Substring(0, 3);

            if(Kr1 <= 0)
            {
                result.Text = "Impossível";
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajuda3(), true);
        }
    }
}