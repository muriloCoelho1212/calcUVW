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

        private void Calcular_Clicked(object sender, EventArgs e)
        {
            double Lv = varFatorK.Lv;
            double Espv = varFatorK.Espv;
            double Cv = Convert.ToDouble(C.Text);
            double Av = Convert.ToDouble(ladoA.Text);
            double Bv = Convert.ToDouble(ladoB.Text);
            double Rv = Convert.ToDouble(raio_dobra.Text);
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

            result.Text = Convert.ToString(K);
            result.Text = result.Text.Substring(0, 4);
        }
    }
}