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
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovRacun = new System.Windows.Forms.Label();
            this.placenoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpozorenjeOtpremnice = new System.Windows.Forms.Label();
            this.neobracunateOtpremnice = new System.Windows.Forms.Label();
            this.obracunateOtpremniceLabel = new System.Windows.Forms.Label();
            this.btnMakniSve = new System.Windows.Forms.Button();
            this.btnMakni = new System.Windows.Forms.Button();
            this.btnDodajSve = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.raspoloziveOtpremniceDgv = new System.Windows.Forms.DataGridView();
            this.pridruzeneOtpremniceDgv = new System.Windows.Forms.DataGridView();
            izdavateljLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspoloziveOtpremniceDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridruzeneOtpremniceDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(3, 2);
            this.controlBox.Margin = new System.Windows.Forms.Padding(4);
            this.controlBox.Size = new System.Drawing.Size(533, 41);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(1045, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(5);
            this.Minimize.Size = new System.Drawing.Size(44, 38);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(1100, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(5);
            this.RestoreDown.Size = new System.Drawing.Size(44, 38);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1156, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(92, 98);
            izdavateljLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(71, 17);
            izdavateljLabel.TabIndex = 37;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(48, 66);
            datum_izdavanjaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(117, 17);
            datum_izdavanjaLabel.TabIndex = 36;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(355, 95);
            this.UpozorenjeIzdavatelj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeIzdavatelj.TabIndex = 41;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // UpozorenjeDatumIzdavanja
            // 
            this.UpozorenjeDatumIzdavanja.AutoSize = true;
            this.UpozorenjeDatumIzdavanja.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumIzdavanja.Location = new System.Drawing.Point(355, 63);
            this.UpozorenjeDatumIzdavanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeDatumIzdavanja.Name = "UpozorenjeDatumIzdavanja";
            this.UpozorenjeDatumIzdavanja.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeDatumIzdavanja.TabIndex = 40;
            this.UpozorenjeDatumIzdavanja.Text = "label1";
            this.UpozorenjeDatumIzdavanja.Visible = false;
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(172, 95);
            this.izdavateljComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(173, 24);
            this.izdavateljComboBox.TabIndex = 39;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(172, 63);
            this.datum_izdavanjaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(173, 22);
            this.datum_izdavanjaDateTimePicker.TabIndex = 38;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(280, 423);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 34;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(172, 423);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 33;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovRacun
            // 
            this.NaslovRacun.AutoSize = true;
            this.NaslovRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRacun.Location = new System.Drawing.Point(16, 11);
            this.NaslovRacun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovRacun.Name = "NaslovRacun";
            this.NaslovRacun.Size = new System.Drawing.Size(98, 31);
            this.NaslovRacun.TabIndex = 32;
            this.NaslovRacun.Text = "Račun";
            // 
            // placenoCheckBox
            // 
            this.placenoCheckBox.AutoSize = true;
            this.placenoCheckBox.Location = new System.Drawing.Point(172, 127);
            this.placenoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placenoCheckBox.Name = "placenoCheckBox";
            this.placenoCheckBox.Size = new System.Drawing.Size(18, 17);
            this.placenoCheckBox.TabIndex = 42;
            this.placenoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Plaćeno:";
            // 
            // UpozorenjeOtpremnice
            // 
            this.UpozorenjeOtpremnice.AutoSize = true;
            this.UpozorenjeOtpremnice.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOtpremnice.Location = new System.Drawing.Point(29, 163);
            this.UpozorenjeOtpremnice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeOtpremnice.Name = "UpozorenjeOtpremnice";
            this.UpozorenjeOtpremnice.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeOtpremnice.TabIndex = 52;
            this.UpozorenjeOtpremnice.Text = "label1";
            this.UpozorenjeOtpremnice.Visible = false;
            // 
            // neobracunateOtpremnice
            // 
            this.neobracunateOtpremnice.AutoSize = true;
            this.neobracunateOtpremnice.Location = new System.Drawing.Point(305, 189);
            this.neobracunateOtpremnice.Name = "neobracunateOtpremnice";
            this.neobracunateOtpremnice.Size = new System.Drawing.Size(176, 17);
            this.neobracunateOtpremnice.TabIndex = 51;
            this.neobracunateOtpremnice.Text = "Neobračunate otpremnice:";
            // 
            // obracunateOtpremniceLabel
            // 
            this.obracunateOtpremniceLabel.AutoSize = true;
            this.obracunateOtpremniceLabel.Location = new System.Drawing.Point(29, 190);
            this.obracunateOtpremniceLabel.Name = "obracunateOtpremniceLabel";
            this.obracunateOtpremniceLabel.Size = new System.Drawing.Size(161, 17);
            this.obracunateOtpremniceLabel.TabIndex = 50;
            this.obracunateOtpremniceLabel.Text = "Obračunate otpremnice:";
            // 
            // btnMakniSve
            // 
            this.btnMakniSve.Location = new System.Drawing.Point(239, 340);
            this.btnMakniSve.Name = "btnMakniSve";
            this.btnMakniSve.Size = new System.Drawing.Size(51, 29);
            this.btnMakniSve.TabIndex = 49;
            this.btnMakniSve.Text = ">>";
            this.btnMakniSve.UseVisualStyleBackColor = true;
            this.btnMakniSve.Click += new System.EventHandler(this.btnMakniSve_Click);
            // 
            // btnMakni
            // 
            this.btnMakni.Location = new System.Drawing.Point(239, 305);
            this.btnMakni.Name = "btnMakni";
            this.btnMakni.Size = new System.Drawing.Size(51, 29);
            this.btnMakni.TabIndex = 48;
            this.btnMakni.Text = ">";
            this.btnMakni.UseVisualStyleBackColor = true;
            this.btnMakni.Click += new System.EventHandler(this.btnMakni_Click);
            // 
            // btnDodajSve
            // 
            this.btnDodajSve.Location = new System.Drawing.Point(239, 270);
            this.btnDodajSve.Name = "btnDodajSve";
            this.btnDodajSve.Size = new System.Drawing.Size(51, 29);
            this.btnDodajSve.TabIndex = 47;
            this.btnDodajSve.Text = "<<";
            this.btnDodajSve.UseVisualStyleBackColor = true;
            this.btnDodajSve.Click += new System.EventHandler(this.btnDodajSve_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(239, 235);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(51, 29);
            this.btnDodaj.TabIndex = 46;
            this.btnDodaj.Text = "<";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // raspoloziveOtpremniceDgv
            // 
            this.raspoloziveOtpremniceDgv.AllowUserToAddRows = false;
            this.raspoloziveOtpremniceDgv.AllowUserToDeleteRows = false;
            this.raspoloziveOtpremniceDgv.AllowUserToResizeRows = false;
            this.raspoloziveOtpremniceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspoloziveOtpremniceDgv.Location = new System.Drawing.Point(296, 210);
            this.raspoloziveOtpremniceDgv.MultiSelect = false;
            this.raspoloziveOtpremniceDgv.Name = "raspoloziveOtpremniceDgv";
            this.raspoloziveOtpremniceDgv.RowHeadersVisible = false;
            this.raspoloziveOtpremniceDgv.RowTemplate.Height = 24;
            this.raspoloziveOtpremniceDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.raspoloziveOtpremniceDgv.Size = new System.Drawing.Size(221, 192);
            this.raspoloziveOtpremniceDgv.TabIndex = 45;
            this.raspoloziveOtpremniceDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.raspoloziveOtpremniceDgv_CellDoubleClick);
            // 
            // pridruzeneOtpremniceDgv
            // 
            this.pridruzeneOtpremniceDgv.AllowUserToAddRows = false;
            this.pridruzeneOtpremniceDgv.AllowUserToDeleteRows = false;
            this.pridruzeneOtpremniceDgv.AllowUserToResizeRows = false;
            this.pridruzeneOtpremniceDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pridruzeneOtpremniceDgv.Location = new System.Drawing.Point(22, 210);
            this.pridruzeneOtpremniceDgv.MultiSelect = false;
            this.pridruzeneOtpremniceDgv.Name = "pridruzeneOtpremniceDgv";
            this.pridruzeneOtpremniceDgv.ReadOnly = true;
            this.pridruzeneOtpremniceDgv.RowHeadersVisible = false;
            this.pridruzeneOtpremniceDgv.RowTemplate.Height = 24;
            this.pridruzeneOtpremniceDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pridruzeneOtpremniceDgv.Size = new System.Drawing.Size(211, 192);
            this.pridruzeneOtpremniceDgv.TabIndex = 44;
            this.pridruzeneOtpremniceDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pridruzeneOtpremniceDgv_CellDoubleClick);
            // 
            // frmRacunUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 472);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeOtpremnice);
            this.Controls.Add(this.neobracunateOtpremnice);
            this.Controls.Add(this.obracunateOtpremniceLabel);
            this.Controls.Add(this.btnMakniSve);
            this.Controls.Add(this.btnMakni);
            this.Controls.Add(this.btnDodajSve);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.raspoloziveOtpremniceDgv);
            this.Controls.Add(this.pridruzeneOtpremniceDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placenoCheckBox);
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(this.UpozorenjeDatumIzdavanja);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRacun);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1707, 1211);
            this.Name = "frmRacunUpdate";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "frmRacunUpdate";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovRacun, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.datum_izdavanjaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_izdavanjaLabel, 0);
            this.Controls.SetChildIndex(this.izdavateljComboBox, 0);
            this.Controls.SetChildIndex(izdavateljLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeDatumIzdavanja, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIzdavatelj, 0);
            this.Controls.SetChildIndex(this.placenoCheckBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.pridruzeneOtpremniceDgv, 0);
            this.Controls.SetChildIndex(this.raspoloziveOtpremniceDgv, 0);
            this.Controls.SetChildIndex(this.btnDodaj, 0);
            this.Controls.SetChildIndex(this.btnDodajSve, 0);
            this.Controls.SetChildIndex(this.btnMakni, 0);
            this.Controls.SetChildIndex(this.btnMakniSve, 0);
            this.Controls.SetChildIndex(this.obracunateOtpremniceLabel, 0);
            this.Controls.SetChildIndex(this.neobracunateOtpremnice, 0);
            this.Controls.SetChildIndex(this.UpozorenjeOtpremnice, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspoloziveOtpremniceDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pridruzeneOtpremniceDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.Label UpozorenjeDatumIzdavanja;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovRacun;
        private System.Windows.Forms.CheckBox placenoCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UpozorenjeOtpremnice;
        private System.Windows.Forms.Label neobracunateOtpremnice;
        private System.Windows.Forms.Label obracunateOtpremniceLabel;
        private System.Windows.Forms.Button btnMakniSve;
        private System.Windows.Forms.Button btnMakni;
        private System.Windows.Forms.Button btnDodajSve;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView raspoloziveOtpremniceDgv;
        private System.Windows.Forms.DataGridView pridruzeneOtpremniceDgv;
    }
}