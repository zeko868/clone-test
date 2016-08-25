namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmTemeljnicaUpdate
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
            System.Windows.Forms.Label artiklLabel;
            System.Windows.Forms.Label vozacLabel;
            System.Windows.Forms.Label voziloLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label datum_izdavanjaLabel;
            this.UpozorenjeArtikl = new System.Windows.Forms.Label();
            this.UpozorenjeVozac = new System.Windows.Forms.Label();
            this.UpozorenjeVozilo = new System.Windows.Forms.Label();
            this.UpozorenjeKolicina = new System.Windows.Forms.Label();
            this.UpozorenjeDatumIzdavanja = new System.Windows.Forms.Label();
            this.artiklComboBox = new System.Windows.Forms.ComboBox();
            this.vozacComboBox = new System.Windows.Forms.ComboBox();
            this.voziloComboBox = new System.Windows.Forms.ComboBox();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovTemeljnica = new System.Windows.Forms.Label();
            artiklLabel = new System.Windows.Forms.Label();
            vozacLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpozorenjeArtikl
            // 
            this.UpozorenjeArtikl.AutoSize = true;
            this.UpozorenjeArtikl.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeArtikl.Location = new System.Drawing.Point(266, 157);
            this.UpozorenjeArtikl.Name = "UpozorenjeArtikl";
            this.UpozorenjeArtikl.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeArtikl.TabIndex = 53;
            this.UpozorenjeArtikl.Text = "label1";
            this.UpozorenjeArtikl.Visible = false;
            // 
            // UpozorenjeVozac
            // 
            this.UpozorenjeVozac.AutoSize = true;
            this.UpozorenjeVozac.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozac.Location = new System.Drawing.Point(266, 130);
            this.UpozorenjeVozac.Name = "UpozorenjeVozac";
            this.UpozorenjeVozac.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeVozac.TabIndex = 52;
            this.UpozorenjeVozac.Text = "label1";
            this.UpozorenjeVozac.Visible = false;
            // 
            // UpozorenjeVozilo
            // 
            this.UpozorenjeVozilo.AutoSize = true;
            this.UpozorenjeVozilo.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozilo.Location = new System.Drawing.Point(266, 103);
            this.UpozorenjeVozilo.Name = "UpozorenjeVozilo";
            this.UpozorenjeVozilo.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeVozilo.TabIndex = 51;
            this.UpozorenjeVozilo.Text = "label1";
            this.UpozorenjeVozilo.Visible = false;
            // 
            // UpozorenjeKolicina
            // 
            this.UpozorenjeKolicina.AutoSize = true;
            this.UpozorenjeKolicina.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeKolicina.Location = new System.Drawing.Point(266, 77);
            this.UpozorenjeKolicina.Name = "UpozorenjeKolicina";
            this.UpozorenjeKolicina.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeKolicina.TabIndex = 50;
            this.UpozorenjeKolicina.Text = "label1";
            this.UpozorenjeKolicina.Visible = false;
            // 
            // UpozorenjeDatumIzdavanja
            // 
            this.UpozorenjeDatumIzdavanja.AutoSize = true;
            this.UpozorenjeDatumIzdavanja.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumIzdavanja.Location = new System.Drawing.Point(266, 51);
            this.UpozorenjeDatumIzdavanja.Name = "UpozorenjeDatumIzdavanja";
            this.UpozorenjeDatumIzdavanja.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeDatumIzdavanja.TabIndex = 49;
            this.UpozorenjeDatumIzdavanja.Text = "label1";
            this.UpozorenjeDatumIzdavanja.Visible = false;
            // 
            // artiklLabel
            // 
            artiklLabel.AutoSize = true;
            artiklLabel.Location = new System.Drawing.Point(91, 160);
            artiklLabel.Name = "artiklLabel";
            artiklLabel.Size = new System.Drawing.Size(33, 13);
            artiklLabel.TabIndex = 46;
            artiklLabel.Text = "Artikl:";
            // 
            // artiklComboBox
            // 
            this.artiklComboBox.FormattingEnabled = true;
            this.artiklComboBox.Location = new System.Drawing.Point(129, 157);
            this.artiklComboBox.Name = "artiklComboBox";
            this.artiklComboBox.Size = new System.Drawing.Size(131, 21);
            this.artiklComboBox.TabIndex = 48;
            this.artiklComboBox.SelectedIndexChanged += new System.EventHandler(this.artiklComboBox_SelectedIndexChanged);
            // 
            // vozacLabel
            // 
            vozacLabel.AutoSize = true;
            vozacLabel.Location = new System.Drawing.Point(84, 133);
            vozacLabel.Name = "vozacLabel";
            vozacLabel.Size = new System.Drawing.Size(40, 13);
            vozacLabel.TabIndex = 44;
            vozacLabel.Text = "Vozac:";
            // 
            // vozacComboBox
            // 
            this.vozacComboBox.FormattingEnabled = true;
            this.vozacComboBox.Location = new System.Drawing.Point(129, 130);
            this.vozacComboBox.Name = "vozacComboBox";
            this.vozacComboBox.Size = new System.Drawing.Size(131, 21);
            this.vozacComboBox.TabIndex = 47;
            this.vozacComboBox.SelectedIndexChanged += new System.EventHandler(this.vozacComboBox_SelectedIndexChanged);
            // 
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(86, 106);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(38, 13);
            voziloLabel.TabIndex = 43;
            voziloLabel.Text = "Vozilo:";
            // 
            // voziloComboBox
            // 
            this.voziloComboBox.FormattingEnabled = true;
            this.voziloComboBox.Location = new System.Drawing.Point(129, 103);
            this.voziloComboBox.Name = "voziloComboBox";
            this.voziloComboBox.Size = new System.Drawing.Size(131, 21);
            this.voziloComboBox.TabIndex = 45;
            this.voziloComboBox.SelectedIndexChanged += new System.EventHandler(this.voziloComboBox_SelectedIndexChanged);
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(77, 80);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(47, 13);
            kolicinaLabel.TabIndex = 41;
            kolicinaLabel.Text = "Kolicina:";
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(129, 77);
            this.kolicinaTextBox.MaxLength = 6;
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(131, 20);
            this.kolicinaTextBox.TabIndex = 42;
            this.kolicinaTextBox.Leave += new System.EventHandler(this.kolicinaTextBox_Leave);
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(36, 55);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(89, 13);
            datum_izdavanjaLabel.TabIndex = 39;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 40;
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 192);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 38;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 192);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 37;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 192);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 36;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovTemeljnica
            // 
            this.NaslovTemeljnica.AutoSize = true;
            this.NaslovTemeljnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTemeljnica.Location = new System.Drawing.Point(12, 9);
            this.NaslovTemeljnica.Name = "NaslovTemeljnica";
            this.NaslovTemeljnica.Size = new System.Drawing.Size(127, 26);
            this.NaslovTemeljnica.TabIndex = 35;
            this.NaslovTemeljnica.Text = "Temeljnica";
            // 
            // frmTemeljnicaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeArtikl);
            this.Controls.Add(this.UpozorenjeVozac);
            this.Controls.Add(this.UpozorenjeVozilo);
            this.Controls.Add(this.UpozorenjeKolicina);
            this.Controls.Add(this.UpozorenjeDatumIzdavanja);
            this.Controls.Add(artiklLabel);
            this.Controls.Add(this.artiklComboBox);
            this.Controls.Add(vozacLabel);
            this.Controls.Add(this.vozacComboBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloComboBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTemeljnica);
            this.Name = "frmTemeljnicaUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTemeljnicaUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeArtikl;
        private System.Windows.Forms.Label UpozorenjeVozac;
        private System.Windows.Forms.Label UpozorenjeVozilo;
        private System.Windows.Forms.Label UpozorenjeKolicina;
        private System.Windows.Forms.Label UpozorenjeDatumIzdavanja;
        private System.Windows.Forms.ComboBox artiklComboBox;
        private System.Windows.Forms.ComboBox vozacComboBox;
        private System.Windows.Forms.ComboBox voziloComboBox;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovTemeljnica;
    }
}