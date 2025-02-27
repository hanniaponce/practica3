namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customTxtBox1 = new practica3.CustomTxtBox();
            this.customBtn1 = new practica3.CustomBtn();
            this.SuspendLayout();
            // 
            // customTxtBox1
            // 
            this.customTxtBox1.AllowedInput = practica3.CustomTxtBox.InputType.Both;
            this.customTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTxtBox1.Location = new System.Drawing.Point(30, 129);
            this.customTxtBox1.Name = "customTxtBox1";
            this.customTxtBox1.Size = new System.Drawing.Size(247, 19);
            this.customTxtBox1.TabIndex = 1;
            // 
            // customBtn1
            // 
            this.customBtn1.Location = new System.Drawing.Point(30, 49);
            this.customBtn1.Name = "customBtn1";
            this.customBtn1.Size = new System.Drawing.Size(131, 51);
            this.customBtn1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 299);
            this.Controls.Add(this.customTxtBox1);
            this.Controls.Add(this.customBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private practica3.CustomBtn customBtn1;
        private practica3.CustomTxtBox customTxtBox1;
    }
}

