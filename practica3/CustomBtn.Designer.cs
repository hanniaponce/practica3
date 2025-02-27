namespace practica3
{
    partial class CustomBtn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnColores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnColores
            // 
            this.BtnColores.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnColores.BackColor = System.Drawing.SystemColors.Control;
            this.BtnColores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnColores.Location = new System.Drawing.Point(0, 0);
            this.BtnColores.Name = "BtnColores";
            this.BtnColores.Size = new System.Drawing.Size(131, 51);
            this.BtnColores.TabIndex = 0;
            this.BtnColores.Text = "Haz click";
            this.BtnColores.UseVisualStyleBackColor = false;
            this.BtnColores.Click += new System.EventHandler(this.BtnColores_Click);
            // 
            // CustomBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnColores);
            this.Name = "CustomBtn";
            this.Size = new System.Drawing.Size(131, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnColores;
    }
}
