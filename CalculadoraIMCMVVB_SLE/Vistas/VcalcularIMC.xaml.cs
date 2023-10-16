using CalculadoraIMCMVVB_SLE.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraIMCMVVB_SLE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VcalcularIMC : ContentPage
    {
        public VcalcularIMC()
        {
            InitializeComponent();
            BindingContext = new VMcalcularIMC(Navigation);
        }
    }
}