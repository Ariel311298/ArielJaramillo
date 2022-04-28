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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                await DisplayAlert("Error", "Debe ingresar el usuario", "Aceptar");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                await DisplayAlert("Error", "Debe ingresar la contraseña", "Aceptar");
                txtPass.Focus();
                return;
            }

            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            if (txtUsuario.Text == "ariel2022" && txtPass.Text == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(usuario, pass));
            }
            else
            {
                await DisplayAlert("Error", "Usuario no registrado en el sistema. Contactese con el administrador para mas información.", "Aceptar");
                return;
            }
           
        }
    }
}