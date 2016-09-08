namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmProizvodniNalog
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
            System.Windows.Forms.Label datum_izdavanjaLabel;
            System.Windows.Forms.Label temperaturaLabel;
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label narudzbenicaLabel;
            this.NaslovProizvodniNalog = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.narudzbenicaComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeTemperatura = new System.Windows.Forms.Label();
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.UpozorenjeNarudzbenica = new System.Windows.Forms.Label();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.btnDohvatiTemperaturu = new System.Windows.Forms.Button();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            narudzbenicaLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(3, 2);
            this.controlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlBox.Size = new System.Drawing.Size(781, 41);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(3413, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Minimize.Size = new System.Drawing.Size(44, 38);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(3467, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RestoreDown.Size = new System.Drawing.Size(44, 38);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3523, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(9, 101);
            datum_izdavanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(117, 17);
            datum_izdavanjaLabel.TabIndex = 22;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(32, 132);
            temperaturaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(94, 17);
            temperaturaLabel.TabIndex = 23;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(52, 164);
            izdavateljLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(71, 17);
            izdavateljLabel.TabIndex = 25;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // narudzbenicaLabel
            // 
            narudzbenicaLabel.AutoSize = true;
            narudzbenicaLabel.Location = new System.Drawing.Point(24, 66);
            narudzbenicaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            narudzbenicaLabel.Name = "narudzbenicaLabel";
            narudzbenicaLabel.Size = new System.Drawing.Size(100, 17);
            narudzbenicaLabel.TabIndex = 26;
            narudzbenicaLabel.Text = "Narudžbenica:";
            // 
            // NaslovProizvodniNalog
            // 
            this.NaslovProizvodniNalog.AutoSize = true;
            this.NaslovProizvodniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovProizvodniNalog.Location = new System.Drawing.Point(16, 11);
            this.NaslovProizvodniNalog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovProizvodniNalog.Name = "NaslovProizvodniNalog";
            this.NaslovProizvodniNalog.Size = new System.Drawing.Size(230, 31);
            this.NaslovProizvodniNalog.TabIndex = 10;
            this.NaslovProizvodniNalog.Text = "Proizvodni nalog";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 207);
            this.GumbReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(100, 28);
            this.GumbReset.TabIndex = 21;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 207);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 20;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 207);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 19;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(133, 96);
            this.datum_izdavanjaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(468, 22);
            this.datum_izdavanjaDateTimePicker.TabIndex = 23;
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.Location = new System.Drawing.Point(133, 128);
            this.temperaturaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temperaturaTextBox.MaxLength = 6;
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(468, 22);
            this.temperaturaTextBox.TabIndex = 24;
            this.temperaturaTextBox.Leave += new System.EventHandler(this.temperaturaTextBox_Leave);
            // 
            // narudzbenicaComboBox
            // 
            this.narudzbenicaComboBox.FormattingEnabled = true;
            this.narudzbenicaComboBox.Location = new System.Drawing.Point(133, 63);
            this.narudzbenicaComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.narudzbenicaComboBox.Name = "narudzbenicaComboBox";
            this.narudzbenicaComboBox.Size = new System.Drawing.Size(468, 24);
            this.narudzbenicaComboBox.TabIndex = 27;
            this.narudzbenicaComboBox.SelectedIndexChanged += new System.EventHandler(this.narudzbenicaComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeTemperatura
            // 
            this.UpozorenjeTemperatura.AutoSize = true;
            this.UpozorenjeTemperatura.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemperatura.Location = new System.Drawing.Point(611, 128);
            this.UpozorenjeTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeTemperatura.Name = "UpozorenjeTemperatura";
            this.UpozorenjeTemperatura.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeTemperatura.TabIndex = 31;
            this.UpozorenjeTemperatura.Text = "label1";
            this.UpozorenjeTemperatura.Visible = false;
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(611, 160);
            this.UpozorenjeIzdavatelj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeIzdavatelj.TabIndex = 33;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // UpozorenjeNarudzbenica
            // 
            this.UpozorenjeNarudzbenica.AutoSize = true;
            this.UpozorenjeNarudzbenica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNarudzbenica.Location = new System.Drawing.Point(611, 66);
            this.UpozorenjeNarudzbenica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeNarudzbenica.Name = "UpozorenjeNarudzbenica";
            this.UpozorenjeNarudzbenica.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeNarudzbenica.TabIndex = 34;
            this.UpozorenjeNarudzbenica.Text = "label1";
            this.UpozorenjeNarudzbenica.Visible = false;
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(133, 160);
            this.izdavateljComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(468, 24);
            this.izdavateljComboBox.TabIndex = 35;
            // 
            // btnDohvatiTemperaturu
            // 
            this.btnDohvatiTemperaturu.Location = new System.Drawing.Point(664, 127);
            this.btnDohvatiTemperaturu.Name = "btnDohvatiTemperaturu";
            this.btnDohvatiTemperaturu.Size = new System.Drawing.Size(74, 23);
            this.btnDohvatiTemperaturu.TabIndex = 36;
            this.btnDohvatiTemperaturu.Text = "Iščitaj";
            this.btnDohvatiTemperaturu.UseVisualStyleBackColor = true;
            this.btnDohvatiTemperaturu.Click += new System.EventHandler(this.btnDohvatiTemperaturu_Click);
            // 
            // frmProizvodniNalog
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(787, 321);
            this.ControlBox = false;
            this.Controls.Add(this.btnDohvatiTemperaturu);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(this.NaslovProizvodniNalog);
            this.Controls.Add(this.UpozorenjeNarudzbenica);
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(this.UpozorenjeTemperatura);
            this.Controls.Add(narudzbenicaLabel);
            this.Controls.Add(this.narudzbenicaComboBox);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(temperaturaLabel);
            this.Controls.Add(this.temperaturaTextBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1707, 1211);
            this.Name = "frmProizvodniNalog";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "frmProizvodniNalog";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.datum_izdavanjaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_izdavanjaLabel, 0);
            this.Controls.SetChildIndex(this.temperaturaTextBox, 0);
            this.Controls.SetChildIndex(temperaturaLabel, 0);
            this.Controls.SetChildIndex(izdavateljLabel, 0);
            this.Controls.SetChildIndex(this.narudzbenicaComboBox, 0);
            this.Controls.SetChildIndex(narudzbenicaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeTemperatura, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIzdavatelj, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNarudzbenica, 0);
            this.Controls.SetChildIndex(this.NaslovProizvodniNalog, 0);
            this.Controls.SetChildIndex(this.izdavateljComboBox, 0);
            this.Controls.SetChildIndex(this.btnDohvatiTemperaturu, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovProizvodniNalog;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.ComboBox narudzbenicaComboBox;
        private System.Windows.Forms.Label UpozorenjeTemperatura;
        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.Label UpozorenjeNarudzbenica;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.Button btnDohvatiTemperaturu;
    }
}