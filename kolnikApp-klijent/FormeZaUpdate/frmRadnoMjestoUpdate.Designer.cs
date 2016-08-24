namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmRadnoMjestoUpdate
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
            System.Windows.Forms.Label nazivLabel;
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovRadnoMjesto = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(235, 51);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNaziv.TabIndex = 37;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 54);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 35;
            nazivLabel.Text = "Naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 51);
            this.nazivTextBox.MaxLength = 45;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 36;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 90);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 34;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 90);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 33;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 90);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 32;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovRadnoMjesto
            // 
            this.NaslovRadnoMjesto.AutoSize = true;
            this.NaslovRadnoMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRadnoMjesto.Location = new System.Drawing.Point(12, 9);
            this.NaslovRadnoMjesto.Name = "NaslovRadnoMjesto";
            this.NaslovRadnoMjesto.Size = new System.Drawing.Size(159, 26);
            this.NaslovRadnoMjesto.TabIndex = 31;
            this.NaslovRadnoMjesto.Text = "Radno mjesto";
            // 
            // frmRadnoMjestoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRadnoMjesto);
            this.Name = "frmRadnoMjestoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRadnoMjestoUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeNaziv;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovRadnoMjesto;
    }
}