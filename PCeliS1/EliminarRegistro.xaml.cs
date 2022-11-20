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
    public partial class EliminarRegistro : ContentPage
    {
        public const string Url = "http://192.168.56.1/estudiantes/post.php?codigo={0}";
        public EliminarRegistro()
        {
            InitializeComponent();
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                var uri = new Uri(string.Format(Url, txtCodigo.Text));
                var result = await client.DeleteAsync(uri);
                if (result.IsSuccessStatusCode)
                {
                    await DisplayAlert("Successfully", "El dato ha sido borrado", "OK");
                }
                else
                {
                    await DisplayAlert("Error", "Estudiante de Codigo:" + txtCodigo.Text + " eliminado;", "OK");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListadoEstudiantes());
        }
    }
}