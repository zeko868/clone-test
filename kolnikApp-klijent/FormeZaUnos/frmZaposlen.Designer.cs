namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmZaposlen
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
            System.Windows.Forms.Label labelaRadnoMjesto;
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label poduzeceLabel;
            System.Windows.Forms.Label zaposlenikLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.UpozorenjeRadnoMjesto = new System.Windows.Forms.Label();
            this.radno_mjestoComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeRazlikaDatuma = new System.Windows.Forms.Label();
            this.UpozorenjePoduzece = new System.Windows.Forms.Label();
            this.UpozorenjeZaposlenik = new System.Windows.Forms.Label();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.poduzeceComboBox = new System.Windows.Forms.ComboBox();
            this.zaposlenikComboBox = new System.Windows.Forms.ComboBox();
            this.NaslovZaposlen = new System.Windows.Forms.Label();
            labelaRadnoMjesto = new System.Windows.Forms.Label();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            poduzeceLabel = new System.Windows.Forms.Label();
            zaposlenikLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Dock = System.Windows.Forms.DockStyle.None;
            this.controlBox.Location = new System.Drawing.Point(3, 2);
            this.controlBox.Margin = new System.Windows.Forms.Padding(4);
            this.controlBox.Size = new System.Drawing.Size(533, 41);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(1116, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(5);
            this.Minimize.Size = new System.Drawing.Size(44, 38);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(1170, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(5);
            this.RestoreDown.Size = new System.Drawing.Size(44, 38);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1226, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
            // 
            // labelaRadnoMjesto
            // 
            labelaRadnoMjesto.AutoSize = true;
            labelaRadnoMjesto.Location = new System.Drawing.Point(67, 134);
            labelaRadnoMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelaRadnoMjesto.Name = "labelaRadnoMjesto";
            labelaRadnoMjesto.Size = new System.Drawing.Size(99, 17);
            labelaRadnoMjesto.TabIndex = 67;
            labelaRadnoMjesto.Text = "Radno mjesto:";
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(47, 201);
            datum_zavrsetkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(118, 17);
            datum_zavrsetkaLabel.TabIndex = 59;
            datum_zavrsetkaLabel.Text = "Datum završetka:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(56, 169);
            datum_pocetkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(107, 17);
            datum_pocetkaLabel.TabIndex = 57;
            datum_pocetkaLabel.Text = "Datum početka:";
            // 
            // poduzeceLabel
            // 
            poduzeceLabel.AutoSize = true;
            poduzeceLabel.Location = new System.Drawing.Point(88, 68);
            poduzeceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            poduzeceLabel.Name = "poduzeceLabel";
            poduzeceLabel.Size = new System.Drawing.Size(75, 17);
            poduzeceLabel.TabIndex = 55;
            poduzeceLabel.Text = "Poduzeće:";
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(84, 101);
            zaposlenikLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(81, 17);
            zaposlenikLabel.TabIndex = 54;
            zaposlenikLabel.Text = "Zaposlenik:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 245);
            this.GumbReset.Margin = new System.Windows.Forms.Padding(4);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(100, 28);
            this.GumbReset.TabIndex = 27;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 245);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 245);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // UpozorenjeRadnoMjesto
            // 
            this.UpozorenjeRadnoMjesto.AutoSize = true;
            this.UpozorenjeRadnoMjesto.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRadnoMjesto.Location = new System.Drawing.Point(359, 130);
            this.UpozorenjeRadnoMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeRadnoMjesto.Name = "UpozorenjeRadnoMjesto";
            this.UpozorenjeRadnoMjesto.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeRadnoMjesto.TabIndex = 66;
            this.UpozorenjeRadnoMjesto.Text = "label1";
            this.UpozorenjeRadnoMjesto.Visible = false;
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(172, 130);
            this.radno_mjestoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(177, 24);
            this.radno_mjestoComboBox.TabIndex = 65;
            // 
            // UpozorenjeRazlikaDatuma
            // 
            this.UpozorenjeRazlikaDatuma.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRazlikaDatuma.Location = new System.Drawing.Point(359, 164);
            this.UpozorenjeRazlikaDatuma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeRazlikaDatuma.Name = "UpozorenjeRazlikaDatuma";
            this.UpozorenjeRazlikaDatuma.Size = new System.Drawing.Size(123, 53);
            this.UpozorenjeRazlikaDatuma.TabIndex = 64;
            this.UpozorenjeRazlikaDatuma.Text = "Datum završetka mora biti veći od datuma početka";
            this.UpozorenjeRazlikaDatuma.Visible = false;
            // 
            // UpozorenjePoduzece
            // 
            this.UpozorenjePoduzece.AutoSize = true;
            this.UpozorenjePoduzece.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePoduzece.Location = new System.Drawing.Point(359, 64);
            this.UpozorenjePoduzece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjePoduzece.Name = "UpozorenjePoduzece";
            this.UpozorenjePoduzece.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjePoduzece.TabIndex = 63;
            this.UpozorenjePoduzece.Text = "label1";
            this.UpozorenjePoduzece.Visible = false;
            // 
            // UpozorenjeZaposlenik
            // 
            this.UpozorenjeZaposlenik.AutoSize = true;
            this.UpozorenjeZaposlenik.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeZaposlenik.Location = new System.Drawing.Point(359, 97);
            this.UpozorenjeZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeZaposlenik.Name = "UpozorenjeZaposlenik";
            this.UpozorenjeZaposlenik.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeZaposlenik.TabIndex = 62;
            this.UpozorenjeZaposlenik.Text = "label1";
            this.UpozorenjeZaposlenik.Visible = false;
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(172, 196);
            this.datum_zavrsetkaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.ShowCheckBox = true;
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 61;
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(172, 164);
            this.datum_pocetkaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.datum_pocetkaDateTimePicker.TabIndex = 60;
            // 
            // poduzeceComboBox
            // 
            this.poduzeceComboBox.FormattingEnabled = true;
            this.poduzeceComboBox.Location = new System.Drawing.Point(172, 64);
            this.poduzeceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.poduzeceComboBox.Name = "poduzeceComboBox";
            this.poduzeceComboBox.Size = new System.Drawing.Size(177, 24);
            this.poduzeceComboBox.TabIndex = 58;
            this.poduzeceComboBox.SelectedIndexChanged += new System.EventHandler(this.poduzeceComboBox_SelectedIndexChanged);
            // 
            // zaposlenikComboBox
            // 
            this.zaposlenikComboBox.FormattingEnabled = true;
            this.zaposlenikComboBox.Location = new System.Drawing.Point(172, 97);
            this.zaposlenikComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.zaposlenikComboBox.Name = "zaposlenikComboBox";
            this.zaposlenikComboBox.Size = new System.Drawing.Size(177, 24);
            this.zaposlenikComboBox.TabIndex = 56;
            this.zaposlenikComboBox.SelectedIndexChanged += new System.EventHandler(this.zaposlenikComboBox_SelectedIndexChanged);
            // 
            // NaslovZaposlen
            // 
            this.NaslovZaposlen.AutoSize = true;
            this.NaslovZaposlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlen.Location = new System.Drawing.Point(16, 11);
            this.NaslovZaposlen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovZaposlen.Name = "NaslovZaposlen";
            this.NaslovZaposlen.Size = new System.Drawing.Size(260, 31);
            this.NaslovZaposlen.TabIndex = 13;
            this.NaslovZaposlen.Text = "Radnik - Poduzeće";
            // 
            // frmZaposlen
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.ControlBox = false;
            this.Controls.Add(labelaRadnoMjesto);
            this.Controls.Add(this.UpozorenjeRadnoMjesto);
            this.Controls.Add(this.radno_mjestoComboBox);
            this.Controls.Add(this.UpozorenjeRazlikaDatuma);
            this.Controls.Add(this.UpozorenjePoduzece);
            this.Controls.Add(this.UpozorenjeZaposlenik);
            this.Controls.Add(datum_zavrsetkaLabel);
            this.Controls.Add(this.datum_zavrsetkaDateTimePicker);
            this.Controls.Add(datum_pocetkaLabel);
            this.Controls.Add(this.datum_pocetkaDateTimePicker);
            this.Controls.Add(poduzeceLabel);
            this.Controls.Add(this.poduzeceComboBox);
            this.Controls.Add(zaposlenikLabel);
            this.Controls.Add(this.zaposlenikComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovZaposlen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1707, 1211);
            this.Name = "frmZaposlen";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "frmZaposen";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovZaposlen, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.zaposlenikComboBox, 0);
            this.Controls.SetChildIndex(zaposlenikLabel, 0);
            this.Controls.SetChildIndex(this.poduzeceComboBox, 0);
            this.Controls.SetChildIndex(poduzeceLabel, 0);
            this.Controls.SetChildIndex(this.datum_pocetkaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_pocetkaLabel, 0);
            this.Controls.SetChildIndex(this.datum_zavrsetkaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_zavrsetkaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeZaposlenik, 0);
            this.Controls.SetChildIndex(this.UpozorenjePoduzece, 0);
            this.Controls.SetChildIndex(this.UpozorenjeRazlikaDatuma, 0);
            this.Controls.SetChildIndex(this.radno_mjestoComboBox, 0);
            this.Controls.SetChildIndex(this.UpozorenjeRadnoMjesto, 0);
            this.Controls.SetChildIndex(labelaRadnoMjesto, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label UpozorenjeRadnoMjesto;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.Label UpozorenjeRazlikaDatuma;
        private System.Windows.Forms.Label UpozorenjePoduzece;
        private System.Windows.Forms.Label UpozorenjeZaposlenik;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.ComboBox poduzeceComboBox;
        private System.Windows.Forms.ComboBox zaposlenikComboBox;
        private System.Windows.Forms.Label NaslovZaposlen;
    }
}