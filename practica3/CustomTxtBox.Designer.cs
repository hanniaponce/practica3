namespace practica3
{
    partial class CustomTxtBox
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
            this.CustomTxBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomTxBox
            // 
            this.CustomTxBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomTxBox.Location = new System.Drawing.Point(0, 0);
            this.CustomTxBox.Name = "CustomTxBox";
            this.CustomTxBox.Size = new System.Drawing.Size(247, 22);
            this.CustomTxBox.TabIndex = 0;
            // 
            // CustomTxtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomTxBox);
            this.Name = "CustomTxtBox";
            this.Size = new System.Drawing.Size(247, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomTxBox;
    }
}
