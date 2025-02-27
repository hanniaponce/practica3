using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3
{
    public partial class CustomBtn : UserControl
    {
      
        public CustomBtn()
        {
            InitializeComponent();
            InicializarButton();


            void InicializarButton()
            {
                BtnColores = new Button();
                BtnColores.Text = "Haz clic aquí";
                BtnColores.Size = new Size(120, 50);
                BtnColores.Location = new Point(10, 10); 

                BtnColores.MouseEnter += (s, e) => BtnColores.BackColor = Color.LightBlue;
                BtnColores.MouseLeave += (s, e) => BtnColores.BackColor = SystemColors.Control;
                BtnColores.DoubleClick += BtnColores_DoubleClick;

                Controls.Add(BtnColores);
            }

        }

        private void BtnColores_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Acción confirmada.");
            }
        }
        private void BtnColores_DoubleClick(object sender, EventArgs e)
        {
            
            MessageBox.Show("Double-click event triggered.");
        }
    }
}
