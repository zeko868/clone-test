namespace kolnikApp_klijent
{
    partial class PanelZaSadrzaj
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
            this.NaslovTablice = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NaslovTablice
            // 
            this.NaslovTablice.AutoSize = true;
            this.NaslovTablice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablice.ForeColor = System.Drawing.Color.White;
            this.NaslovTablice.Location = new System.Drawing.Point(3, 0);
            this.NaslovTablice.Name = "NaslovTablice";
            this.NaslovTablice.Size = new System.Drawing.Size(178, 29);
            this.NaslovTablice.TabIndex = 0;
            this.NaslovTablice.Text = "Naslov tablice";
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Black;
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Location = new System.Drawing.Point(5, 39);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(620, 2);
            this.Separator.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 439);
            this.panel1.TabIndex = 2;
            // 
            // PanelZaSadrzaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.NaslovTablice);
            this.Name = "PanelZaSadrzaj";
            this.Size = new System.Drawing.Size(630, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovTablice;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Panel panel1;
    }
}
