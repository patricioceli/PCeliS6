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
    public partial class SistemaCalificaciones : ContentPage
    {
        public SistemaCalificaciones()
        {
            InitializeComponent();
        }

        private void btnParcial1_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNotaSeguimiento1.Text))
            {
                if (!String.IsNullOrEmpty(txtNotaExamen1.Text))
                {
                    double notaSeguimiento = (Convert.ToDouble(txtNotaSeguimiento1.Text) * 0.3);
                    double notaExamen = (Convert.ToDouble(txtNotaExamen1.Text) * 0.2);
                    double total = notaSeguimiento + notaExamen;
                    txtNotaParcial1.Text = total.ToString();

                }
                else
                {
                    DisplayAlert("Error", "Debe Ingresar la Nota de Examen Parcial 1", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Error", "Debe Ingresar la Nota de Seguimiento Parcial 1", "Cerrar");
            }
        }

        private void btnParcial2_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNotaSeguimiento2.Text))
            {
                if (!String.IsNullOrEmpty(txtNotaExamen2.Text))
                {
                    double notaSeguimiento = (Convert.ToDouble(txtNotaSeguimiento2.Text) * 0.3);
                    double notaExamen = (Convert.ToDouble(txtNotaExamen2.Text) * 0.2);
                    double total = notaSeguimiento + notaExamen;
                    txtNotaParcial2.Text = total.ToString();
                }
                else
                {
                    DisplayAlert("Error", "Debe Ingresar la Nota de Examen Parcial 2", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Error", "Debe Ingresar la Nota de Seguimiento Parcial 2", "Cerrar");
            }
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry ent = (sender as Entry);
            if (!String.IsNullOrEmpty(ent.Text))
            {
                int valor = Convert.ToInt32(ent.Text);

                if (valor < 1 || valor > 10)
                {
                    DisplayAlert("Error", "El valor debe estar entre 1 y 10", "Cerrar");
                    ent.Focus();
                    ent.Text = String.Empty;
                }
            }


        }

        private void btnVerificar_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNotaParcial1.Text))
            {
                if (!String.IsNullOrEmpty(txtNotaParcial2.Text))
                {
                    decimal valor = Convert.ToDecimal(txtNotaParcial2.Text) + Convert.ToDecimal(txtNotaParcial1.Text);

                    if (valor >= 7)
                    {
                        DisplayAlert("Estado", "El estudiante esta APROBADO", "Cerrar");
                    }
                    else if (valor >= 5)
                    {
                        DisplayAlert("Estado", "El estudiante esta en COMPLEMENTARIO", "Cerrar");
                    }
                    else
                    {
                        DisplayAlert("Estado", "El estudiante esta REPROBADO", "Cerrar");
                    }
                }
                else
                {
                    DisplayAlert("Error", "Debe Calcular Primero el Parcial 2", "Cerrar");
                }
            }
            else
            {
                DisplayAlert("Error", "Debe Calcular Primero el Parcial 1", "Cerrar");
            }
        }
    }
}