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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contrasena)
        {
            InitializeComponent();
            lblNombre.Text = usuario;
        }

        private void btnCalcularPM_Clicked(object sender, EventArgs e)
        {
            try
            {
                double cuotaInicial = Convert.ToDouble(txtCuotaInicial.Text);
                double costoCurso = 3000.00;
                double pagoInicial = (costoCurso - cuotaInicial) / 5 + costoCurso * 0.05;
                txtPagoInicial.Text = pagoInicial.ToString();       
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = lblNombre.Text;
            string nombre = txtNombreAlumno.Text;
            double cuotaInicial = Convert.ToDouble(txtCuotaInicial.Text);
            double pagoInicial = Convert.ToDouble(txtPagoInicial.Text);
            double total = pagoInicial * 5 + cuotaInicial;
            await Navigation.PushAsync(new Resumen(nombre, total, usuario));
        }
    }
}