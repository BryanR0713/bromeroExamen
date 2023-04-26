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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string Pagomensual, string nombre, string Minical)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre;
            double datoUno = Convert.ToDouble(Pagomensual);
            double datoDos = Convert.ToDouble(Minical);

            double total = ((datoDos) + (datoUno * 3));
            txtPagoMensual.Text = total.ToString();

        }
    }
}