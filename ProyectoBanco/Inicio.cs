using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Indico las acciones a realizar cuando el formulario se carga//

            btnSolicitarPréstamo.Enabled = false;
        }


        private void controlBotones()
        {

            if ((Nombre.Text.Trim() != string.Empty) &&( Nombre.Text.All(Char.IsLetter)))
            {
                btnSolicitarPréstamo.Enabled = true;
                errorProvider1.SetError(Nombre, "");
            }

            else
            {
                if (!(Nombre.Text.All(Char.IsLetter))) //Si no ingreso una letra...
                {
                    errorProvider1.SetError(Nombre, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(Nombre, "Debe introducir su nombre");
                }

                btnSolicitarPréstamo.Enabled = false;
                Nombre.Focus();
            }
        }


        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSolicitarPréstamo_Click(object sender, EventArgs e)
        {
            using (Prestamos ventanaPrestamos = new Prestamos(Nombre.Text))
                ventanaPrestamos.ShowDialog();
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}


