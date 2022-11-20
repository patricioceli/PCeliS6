using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCeliS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActualizarRegistro : ContentPage
    {
      
        public ActualizarRegistro(int codigo, string nombre, string apellido, string correo, string telefono)
        {
            InitializeComponent();
            txtCodigo.Text = codigo.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCorreo.Text = correo;
            txtTelefono.Text = telefono;
        }



        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListadoEstudiantes());

        }


        public const string Url = "http://192.168.56.1/estudiantes/post.php?codigo={0}&nombre={1}&apellido={2}&correo={3}&telefono={4}";


        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();
            try
            {
                using (var webClient = new WebClient())
                {
                    var uri = new Uri(string.Format(Url, 
                        txtCodigo.Text, txtNombre.Text,txtApellido.Text, txtCorreo.Text, txtTelefono.Text));
                     webClient.UploadString(uri,"PUT", string.Empty);
                     DisplayAlert("Sucess", "Registro de "+ txtNombre.Text+ " " + txtApellido.Text+ " actualizado correctamente",
                        "Cerrar");
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}