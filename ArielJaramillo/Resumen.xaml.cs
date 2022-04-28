using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArielJaramillo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double total)
        {
            InitializeComponent();
            DisplayAlert("Datos enviados", "Elemento guardado con exito", "Cerrar");
            lblNombreAlumno.Text = nombre;
            lblTotal.Text = Convert.ToDouble(total).ToString();
        }

        private void txtTotal_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }
    }
}