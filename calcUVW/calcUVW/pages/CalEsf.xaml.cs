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

        private void CalEsfCalc()
        {
            double De = Convert.ToDouble(DiamtroFe.Text);
            double D;
            double ap = Convert.ToDouble(ProfCorte.Text);
            double RPM = Convert.ToDouble(diamRpm.Text);
            double NRPM;
            double R;
            double vc;

            R = De / 2;

            if (ap < R)
            {
                vc = RPM * De * 3.14159265 / 1000;

                D = 2 * Math.Pow((Math.Pow(R, 2) - Math.Pow((R - ap), 2)), 0);

                NRPM = vc * 1000 / (D * 3.14159265); 

                calResult.Text = D.ToString("N3");
                rpmResult.Text = NRPM.ToString("N3");
            }
            else
            {
                calResult.Text = De.ToString();
                rpmResult.Text = ((double)Convert.ToDouble(diamRpm.Text)).ToString();
            }
        }
        private void calcular_Clicked(object sender, EventArgs e)
        {
            calResult.Text = "";
            rpmResult.Text = "";
            CalEsfCalc();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ajudaCAL(), true);
        }
    }
}