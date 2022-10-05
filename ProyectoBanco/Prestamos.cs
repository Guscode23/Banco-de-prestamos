using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco
{
    public partial class Prestamos : Form
    {

        string nombreCliente;
        string[] ProvinciasDisponibles = { "Buenos Aires",
          "Ciudad Autónoma de Buenos Aires",
           "Catamarca",
            "Chaco",
           "Chubut",
           "Córdoba",
          "Corrientes",
          "Entre Ríos",
            "Formosa",
            "Jujuy",
          "La Pampa",
           "La Rioja",
           "Mendoza",
          "Misiones",
          "Neuquén",
          "Río Negro",
           "Salta",
         "San Juan",
         "San Luis",
         "Santa Cruz",
          "Santa Fe",
       "Santiago del Estero",
        "Tierra del Fuego",
           "Tucumán", };

        int[] cuotasdisponibles = { 12, 24, 36, 60, 120, 180, 240 };


        Dictionary<int, double> intereses_base;

        public Prestamos(string Nombre)
        {
            InitializeComponent();
            nombreCliente = Nombre;


            intereses_base = new Dictionary<int, double>();
            int i;
            double interes;

            for (i = 0, interes = 3.0; i < cuotasdisponibles.Length; i++, interes += 0.5)
            {
                intereses_base[cuotasdisponibles[i]] = interes;
            }

        }


        //¿Qué ocurre cuando cargo la ventana?//
        private void Prestamos_Load(object sender, EventArgs e)
        {

            popularCuotas();
            PopularProvincias();
            Saludo.Text += nombreCliente; //Al saludo inicial, le agrego el nombre del cliente//
        }

        void popularCuotas()
        {

            //Agrego los elementos del array a la lista del Combobox//

            for (int i = 0; i < cuotasdisponibles.Length; i++)
            {
                cuotas.Items.Add(cuotasdisponibles[i]);
            }
        }

        void PopularProvincias()
        {
            //Realizo lo mismo que en el caso anterior//

            for (int i = 0; i < cuotasdisponibles.Length; i++)
            {
                Provincias.Items.Add(ProvinciasDisponibles[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método para calcular interés//

        double CalcularInteres()
        {
            int cuotas_pedidas = (int)cuotas.SelectedItem;
            string provincia_seleccionada = Provincias.SelectedItem.ToString();
            double interes = intereses_base[cuotas_pedidas];

            if (new[] { "Buenos Aires", "Córdoba", "Santa Fe", "Mendoza" }.Contains(provincia_seleccionada))
            {
                interes += 0.3;
            }

            return interes;
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {



            switch (validaciones())
            {

                case 0:
                    errorProvider1.SetError(DatosPersonales, "");
                    errorProvider1.SetError(DetalledelPrestamo, "");
                    double interes_mensual = CalcularInteres();
                    double monto_pedido = double.Parse(Monto.Text);
                    int cuotas_pedidas = (int)cuotas.SelectedItem;
                    double interes_total = monto_pedido * (interes_mensual / 100) * cuotas_pedidas;
                    double MontoaPagar = monto_pedido + interes_total;
                    string mensaje = "Su préstamo por  " + monto_pedido + " en " + cuotas_pedidas + "  cuotas se concederá con un interés del  "+ interes_mensual + " % mensual\nEl monto final asciende a $" + MontoaPagar;
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, "Cálculo de intereses", buttons);
                    break;

                case 1:
                    {
                        errorProvider1.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider1.SetError(DetalledelPrestamo, "");
                        break;
                    }

                case 2:
                    {
                        errorProvider1.SetError(DetalledelPrestamo, "Debe ingresar un monto numerico y una cantidad de cuotas");
                        errorProvider1.SetError(DetalledelPrestamo, "");
                        break;

                    }

            }

            int validaciones()
            {
                if ((Provincias.SelectedIndex <= -1))
                {
                    return 1;
                }
                else
                {
                    if (!(Monto.Text.All(Char.IsDigit)) || (Monto.Text == "") || (cuotas.SelectedIndex <= -1))
                    {

                        return 2;
                    }
                    else
                    {

                        return 0;
                    }

                }
            }
        }
    }

}
