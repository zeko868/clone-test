namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRadnoMjesto
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
            this.NaslovRadnoMjesto = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 54);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 19;
            nazivLabel.Text = "Naziv:";
            // 
            // NaslovRadnoMjesto
            // 
            this.NaslovRadnoMjesto.AutoSize = true;
            this.NaslovRadnoMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRadnoMjesto.Location = new System.Drawing.Point(12, 9);
            this.NaslovRadnoMjesto.Name = "NaslovRadnoMjesto";
            this.NaslovRadnoMjesto.Size = new System.Drawing.Size(159, 26);
            this.NaslovRadnoMjesto.TabIndex = 9;
            this.NaslovRadnoMjesto.Text = "Radno mjesto";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 90);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 18;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 90);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 17;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 90);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 51);
            this.nazivTextBox.MaxLength = 45;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 20;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(235, 51);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNaziv.TabIndex = 30;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // frmRadnoMjesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRadnoMjesto);
            this.Name = "frmRadnoMjesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRadnoMjesto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRadnoMjesto;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label UpozorenjeNaziv;
    }
}