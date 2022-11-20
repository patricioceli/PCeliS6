using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCeliS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarRegistro : ContentPage
    {
        public const string Url = "http://192.168.56.1/estudiantes/post.php";
        public AgregarRegistro()
        {
            InitializeComponent();
        }

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
            WebClient cliente = new WebClient();
            try
            {
                var parameters = new System.Collections.Specialized.NameValueCollection();
                parameters.Add("codigo", txtCodigo.Text);
                parameters.Add("nombre", txtNombre.Text);
                parameters.Add("apellido", txtApellido.Text);
                parameters.Add("correo", txtCorreo.Text);
                parameters.Add("telefono", txtTelefono.Text);
                cliente.UploadValues(Url, "POST", parameters);
                DisplayAlert("Sucess", "Registro Ingresado del Usuario: " + txtNombre.Text+ " " + txtApellido.Text, "Cerrar");
                Limpiar();
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
           
        }

        public void Limpiar()
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }


        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListadoEstudiantes());
        }
    }
}