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

        private void calcular_Clicked(object sender, EventArgs e)
        {
            double De;
            double D;
            double ap;
            double RPM;
            double NRPM;
            double R;
            double vc;
        }
    }
}