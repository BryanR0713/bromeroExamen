using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bromeroExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;

        }

        private void btnCalcularPago_Clicked(object sender, EventArgs e)
        {
            double Minicial = double.Parse(txtMinicial.Text);
            double Pagomensual = 0.00;
            double recargo = 0.05;
            if (Minicial < 3000 && Minicial >= 0)
            {
                Pagomensual = ((3000 - Minicial) / 3) + (recargo * 3000);
                txtPago.Text = Pagomensual.ToString();
            }
            else {
                DisplayAlert("Alerta", "Monto Minimo debe ser menor a 3000 y mayor a 0", "Cerrar");
                txtMinicial.Text = "";

            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Elemento guardado con exito", "Cerrar");

            Navigation.PushAsync(new Resumen(txtUsuario.Text, txtPago.Text, txtNombre.Text, txtMinicial.Text));

        }
    }
}