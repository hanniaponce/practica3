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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnRFC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customTxtBox1 = new practica3.CustomTxtBox();
            this.customBtn1 = new practica3.CustomBtn();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(76, 184);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(213, 22);
            this.txtEntrada.TabIndex = 2;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(76, 258);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(213, 22);
            this.txtRFC.TabIndex = 3;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(391, 156);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(104, 50);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnRFC
            // 
            this.btnRFC.Location = new System.Drawing.Point(391, 230);
            this.btnRFC.Name = "btnRFC";
            this.btnRFC.Size = new System.Drawing.Size(104, 50);
            this.btnRFC.TabIndex = 5;
            this.btnRFC.Text = "RFC";
            this.btnRFC.UseVisualStyleBackColor = true;
            this.btnRFC.Click += new System.EventHandler(this.btnRFC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Validaciones";
            // 
            // customTxtBox1
            // 
            this.customTxtBox1.AllowedInput = practica3.CustomTxtBox.InputType.Both;
            this.customTxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTxtBox1.Location = new System.Drawing.Point(42, 45);
            this.customTxtBox1.Name = "customTxtBox1";
            this.customTxtBox1.Size = new System.Drawing.Size(247, 19);
            this.customTxtBox1.TabIndex = 1;
            // 
            // customBtn1
            // 
            this.customBtn1.Location = new System.Drawing.Point(391, 28);
            this.customBtn1.Name = "customBtn1";
            this.customBtn1.Size = new System.Drawing.Size(131, 51);
            this.customBtn1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRFC);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.customTxtBox1);
            this.Controls.Add(this.customBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private practica3.CustomBtn customBtn1;
        private practica3.CustomTxtBox customTxtBox1;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnRFC;
        private System.Windows.Forms.Label label1;
    }
}

