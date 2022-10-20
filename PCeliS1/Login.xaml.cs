using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCeliS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            string user = "pceli";
            string pass = "12345";


            if (!String.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!String.IsNullOrEmpty(txtContrasena.Text))
                {
                    string tUsuario = txtUsuario.Text;
                    string tPass = txtContrasena.Text;

                    if (user == tUsuario)
                    {
                        if (pass == tPass)
                        {
                            DisplayAlert("Success", "Acceso exitoso.", "OK");
                            Navigation.PushAsync(new SistemaCalificaciones());
                        }
                        else
                        {
                            DisplayAlert("Alerta", "Password Incorrecto.", "Cerrar");
                        }
                    }
                    else
                    {
                        DisplayAlert("Alerta", "Usuario Incorrecto.", "Cerrar");
                    }

                }
                else
                {
                    DisplayAlert("Mensaje de Error", "Debe ingresar el Usuario.", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Mensaje de Error", "Debe ingresar el Password", "Cerrar");
            }

        }


    }
}