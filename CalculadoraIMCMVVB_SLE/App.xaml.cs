using CalculadoraIMCMVVB_SLE.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraIMCMVVB_SLE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VcalcularIMC();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
