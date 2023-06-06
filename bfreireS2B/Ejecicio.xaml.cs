using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bfreireS2B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejecicio : ContentPage
    {
        double totalExamen1;
        double valueExamen1;
        double totalNota1;
        double valueNota1;

        double totalExamen2;
        double valueExamen2;
        double totalNota2;
        double valueNota2;

        double promedioFinal;


        public Ejecicio()
        {
            InitializeComponent();
        }

        private void Paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Paises.SelectedIndex == -1)
            //{
            //    DisplayAlert("Alerta", "Valor Nulo", "Cerrar");
            //}
            //else
            //{
            //    DisplayAlert("Alerta", Paises.Items[Paises.SelectedIndex], "Cerrar");
            //}
        }

        private void btnFecha_Clicked_1(object sender, EventArgs e)
        {
            string fecha = Fechas.Date.ToString("d/MM/yyyy");
            DisplayAlert("Alerta", "La fecha es " + fecha, "Cerrar");
        }

        private void txtNota1_Unfocused(object sender, FocusEventArgs e)
        {
            valueNota1 = Convert.ToDouble(txtNota1.Text);
            totalNota1 = (valueNota1 * 0.3) / 10;
            if (valueNota1 > 0.1 && valueNota1 < 10.1)
            {

            }
            else
            {
                DisplayAlert("Error!", "No es una valor permitido", "Cerrar");
                txtNota1.Text = "";
                txtNota1.Focus();
            }

        }

        private void examenNota1_Unfocused(object sender, FocusEventArgs e)
        {
            valueExamen1 = Convert.ToDouble(txtExamenNota1.Text);
            totalExamen1 = (valueExamen1 * 0.2) / 10;
            if (valueExamen1 > 0.1 && valueExamen1 < 10.1)
            {

            }
            else
            {
                DisplayAlert("Error!", "No es una valor permitido", "Cerrar");
                txtExamenNota1.Text = "";
                txtExamenNota1.Focus();
            }
        }

        private void btnPromedioParcial1_Clicked(object sender, EventArgs e)
        {
            if (txtNota1.Text != "" && txtExamenNota1.Text != "")
            {
                double promedio = (totalNota1 + totalExamen1);
                lblPromedio1.Text = promedio.ToString();
            }
            else
            {
                DisplayAlert("Aviso", "Ingrese calificaciones para calcular", "Cerrar");
            }


        }

        private void txtNota2_Unfocused(object sender, FocusEventArgs e)
        {

            valueNota2 = Convert.ToDouble(txtNota2.Text);
            totalNota2 = (valueNota2 * 0.3) / 10;
            if (valueNota2 > 0.1 && valueNota2 < 10.1)
            {

            }
            else
            {
                DisplayAlert("Error!", "No es una valor permitido", "Cerrar");
                txtNota2.Text = "";
                txtNota2.Focus();
            }

        }

        private void txtExamenNota2_Unfocused(object sender, FocusEventArgs e)
        {
            valueExamen2 = Convert.ToDouble(txtExamenNota2.Text);
            totalExamen2 = (valueExamen2 * 0.2) / 10;
            if (valueExamen2 > 0.1 && valueExamen2 < 10.1)
            {

            }
            else
            {
                DisplayAlert("Error!", "No es una valor permitido", "Cerrar");
                txtExamenNota2.Text = "";
                txtExamenNota2.Focus();
            }
        }

        private void btnPromedioFinal_Clicked(object sender, EventArgs e)
        {
            if (lblPromedio1.Text != "" && lblPromedio2.Text != "")
            {
                promedioFinal = Convert.ToDouble(lblPromedio1.Text) + Convert.ToDouble(lblPromedio2.Text);
                DisplayAlert("Aviso", Convert.ToString(promedioFinal), "Cerrar");
            }
            else
            {
                DisplayAlert("Aviso", "No hay priomedio final que calular", "Cerrar");
            }
            if(promedioFinal < 5)
            {
                resultado.Text = "Reprobado";
                resultado.TextColor = Color.Red;
            }
            else if (promedioFinal >= 5 && promedioFinal <= 6.99)
            {
                resultado.Text = "Complementario";
                resultado.TextColor = Color.Yellow;
            }
            else if (promedioFinal >= 7 )
            {
                resultado.Text = "Aprobado";
                resultado.TextColor = Color.Green;
            }
        }

        private void btnPromedioParcial2_Clicked(object sender, EventArgs e)
        {
            if (txtNota2.Text != "" && txtExamenNota2.Text != "")
            {
                double promedio2 = (promedio2 + promedio);
                lblPromedio2.Text = promedio2.ToString();
            }
            else
            {
                DisplayAlert("Aviso", "Ingrese calificaciones para calcular", "Cerrar");
            }
        }
    }
}