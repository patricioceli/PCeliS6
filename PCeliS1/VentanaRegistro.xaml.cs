using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCeliS1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IngresoNotas : ContentPage
    {
        public IngresoNotas()
        {
            InitializeComponent();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota = Convert.ToDouble(txtNota.Text);

            if (nota >= 7)
            {
                DisplayAlert("Success", "Tu nombre es:" + nombre + " " + apellido + "APROBASTE", "OK");
            }
            else
            {
                DisplayAlert("Success", "Tu nombre es:" + nombre + " " + apellido + "REPROBASTE", "OK");
            }
        }
    }
}