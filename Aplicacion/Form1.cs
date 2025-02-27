using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica3;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string entrada = txtEntrada.Text;

            // se crea una instancia de la clase ClassEntrada
            ClassEntrada validador = new ClassEntrada();

            // se manda a llamar al método de validación de la clase ClassEntrada
            bool esValido = validador.ValidarEntrada(entrada);

            // se muestra un mensaje dependiendo del resultado de la validación
            if (esValido)
            {
                MessageBox.Show("La entrada es válida.");
            }
            else
            {
                MessageBox.Show("La entrada no es válida.");
            }
        }

        private void btnRFC_Click(object sender, EventArgs e)
        {
            try
            {
                // se obtiene el texto del TextBox
                string rfc = txtRFC.Text;

                // creamos una instancia de la clase ClassRFC
                ClassRFC validadorRFC = new ClassRFC();

                // mandara llamar al método de validación de la clase ClassRFC
                bool esValido = validadorRFC.ValidarRFC(rfc);

                // muestra mensaje dependiendo del resultado de la validación
                if (esValido)
                {
                    MessageBox.Show("El RFC es válido.");
                }
                else
                {
                    MessageBox.Show("El RFC no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
 }

