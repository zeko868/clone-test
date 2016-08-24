namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmRacunUpdate
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
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label datum_izdavanjaLabel;
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.UpozorenjeDatumIzdavanja = new System.Windows.Forms.Label();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovRacun = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(266, 77);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIzdavatelj.TabIndex = 41;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // UpozorenjeDatumIzdavanja
            // 
            this.UpozorenjeDatumIzdavanja.AutoSize = true;
            this.UpozorenjeDatumIzdavanja.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumIzdavanja.Location = new System.Drawing.Point(266, 51);
            this.UpozorenjeDatumIzdavanja.Name = "UpozorenjeDatumIzdavanja";
            this.UpozorenjeDatumIzdavanja.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeDatumIzdavanja.TabIndex = 40;
            this.UpozorenjeDatumIzdavanja.Text = "label1";
            this.UpozorenjeDatumIzdavanja.Visible = false;
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(69, 80);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(55, 13);
            izdavateljLabel.TabIndex = 37;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(129, 77);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(131, 21);
            this.izdavateljComboBox.TabIndex = 39;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(36, 54);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(89, 13);
            datum_izdavanjaLabel.TabIndex = 36;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 38;
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 121);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 35;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 121);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 34;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 121);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 33;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovRacun
            // 
            this.NaslovRacun.AutoSize = true;
            this.NaslovRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRacun.Location = new System.Drawing.Point(12, 9);
            this.NaslovRacun.Name = "NaslovRacun";
            this.NaslovRacun.Size = new System.Drawing.Size(80, 26);
            this.NaslovRacun.TabIndex = 32;
            this.NaslovRacun.Text = "Račun";
            // 
            // frmRacunUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(this.UpozorenjeDatumIzdavanja);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRacun);
            this.Name = "frmRacunUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRacunUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.Label UpozorenjeDatumIzdavanja;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovRacun;
    }
}