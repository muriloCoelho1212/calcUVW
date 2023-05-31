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
            double piv = 3.141592653;
            double lla;
            double llb;
            double llc;
            double blankraiototal;
            double blank1raio;
            double K;
        }
    }
}