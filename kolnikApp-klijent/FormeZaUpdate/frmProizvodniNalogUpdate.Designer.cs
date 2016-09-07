namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmProizvodniNalogUpdate
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
            System.Windows.Forms.Label narudzbenicaLabel;
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label temperaturaLabel;
            System.Windows.Forms.Label datum_izdavanjaLabel;
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovProizvodniNalog = new System.Windows.Forms.Label();
            this.UpozorenjeNarudzbenica = new System.Windows.Forms.Label();
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.UpozorenjeTemperatura = new System.Windows.Forms.Label();
            this.narudzbenicaComboBox = new System.Windows.Forms.ComboBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            narudzbenicaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(2, 2);
            this.controlBox.Size = new System.Drawing.Size(586, 33);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(754, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(795, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(837, 0);
            // 
            // narudzbenicaLabel
            // 
            narudzbenicaLabel.AutoSize = true;
            narudzbenicaLabel.Location = new System.Drawing.Point(18, 54);
            narudzbenicaLabel.Name = "narudzbenicaLabel";
            narudzbenicaLabel.Size = new System.Drawing.Size(76, 13);
            narudzbenicaLabel.TabIndex = 43;
            narudzbenicaLabel.Text = "Narudžbenica:";
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(39, 133);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(55, 13);
            izdavateljLabel.TabIndex = 42;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(24, 107);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(70, 13);
            temperaturaLabel.TabIndex = 39;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(7, 82);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(89, 13);
            datum_izdavanjaLabel.TabIndex = 38;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 168);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 37;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 168);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 36;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovProizvodniNalog
            // 
            this.NaslovProizvodniNalog.AutoSize = true;
            this.NaslovProizvodniNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovProizvodniNalog.Location = new System.Drawing.Point(12, 9);
            this.NaslovProizvodniNalog.Name = "NaslovProizvodniNalog";
            this.NaslovProizvodniNalog.Size = new System.Drawing.Size(189, 26);
            this.NaslovProizvodniNalog.TabIndex = 35;
            this.NaslovProizvodniNalog.Text = "Proizvodni nalog";
            // 
            // UpozorenjeNarudzbenica
            // 
            this.UpozorenjeNarudzbenica.AutoSize = true;
            this.UpozorenjeNarudzbenica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNarudzbenica.Location = new System.Drawing.Point(456, 51);
            this.UpozorenjeNarudzbenica.Name = "UpozorenjeNarudzbenica";
            this.UpozorenjeNarudzbenica.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNarudzbenica.TabIndex = 47;
            this.UpozorenjeNarudzbenica.Text = "label1";
            this.UpozorenjeNarudzbenica.Visible = false;
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(458, 130);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIzdavatelj.TabIndex = 46;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // UpozorenjeTemperatura
            // 
            this.UpozorenjeTemperatura.AutoSize = true;
            this.UpozorenjeTemperatura.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemperatura.Location = new System.Drawing.Point(458, 104);
            this.UpozorenjeTemperatura.Name = "UpozorenjeTemperatura";
            this.UpozorenjeTemperatura.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemperatura.TabIndex = 45;
            this.UpozorenjeTemperatura.Text = "label1";
            this.UpozorenjeTemperatura.Visible = false;
            // 
            // narudzbenicaComboBox
            // 
            this.narudzbenicaComboBox.FormattingEnabled = true;
            this.narudzbenicaComboBox.Location = new System.Drawing.Point(100, 51);
            this.narudzbenicaComboBox.Name = "narudzbenicaComboBox";
            this.narudzbenicaComboBox.Size = new System.Drawing.Size(352, 21);
            this.narudzbenicaComboBox.TabIndex = 44;
            this.narudzbenicaComboBox.SelectedIndexChanged += new System.EventHandler(this.narudzbenicaComboBox_SelectedIndexChanged);
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.Location = new System.Drawing.Point(100, 104);
            this.temperaturaTextBox.MaxLength = 6;
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(352, 20);
            this.temperaturaTextBox.TabIndex = 41;
            this.temperaturaTextBox.Leave += new System.EventHandler(this.temperaturaTextBox_Leave);
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(100, 78);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(352, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 40;
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(100, 130);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(352, 21);
            this.izdavateljComboBox.TabIndex = 48;
            // 
            // frmProizvodniNalogUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.ControlBox = false;
            this.Controls.Add(this.izdavateljComboBox);
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
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovProizvodniNalog);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmProizvodniNalogUpdate";
            this.Text = "frmTemeljnicaUpdate";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovProizvodniNalog, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
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
            this.Controls.SetChildIndex(this.izdavateljComboBox, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovProizvodniNalog;
        private System.Windows.Forms.Label UpozorenjeNarudzbenica;
        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.Label UpozorenjeTemperatura;
        private System.Windows.Forms.ComboBox narudzbenicaComboBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
    }
}