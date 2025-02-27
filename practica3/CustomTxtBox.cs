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
    public partial class CustomTxtBox : UserControl
    {
        public enum InputType { LettersOnly, NumbersOnly, Both }

        public InputType AllowedInput { get; set; } = InputType.Both;

        private Color _borderColor = Color.Gray;


        public CustomTxtBox()
        {
            BorderStyle = BorderStyle.FixedSingle;
            this.KeyPress += CustomTxtBox_KeyPress;
        }

        private void CustomTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isValid = true;

            if (AllowedInput == InputType.LettersOnly && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                isValid = false;
            else if (AllowedInput == InputType.NumbersOnly && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                isValid = false;

            if (!isValid)
            {
                e.Handled = true; // bloquea los caracteres invalidos
                _borderColor = Color.Red; // el borde cambia de gris a rojo
            }
            else
            {
                _borderColor = Color.Gray; // borde gris
            }

            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, _borderColor, ButtonBorderStyle.Solid);
        }

            }
        }
