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
            System.Windows.Forms.Label zaposlenikLabel;
            System.Windows.Forms.Label poduzeceLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            this.NaslovZaposlen = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.zaposlenikComboBox = new System.Windows.Forms.ComboBox();
            this.poduzeceComboBox = new System.Windows.Forms.ComboBox();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpozorenjeZaposlenik = new System.Windows.Forms.Label();
            this.UpozorenjePoduzece = new System.Windows.Forms.Label();
            this.UpozorenjeRazlikaDatuma = new System.Windows.Forms.Label();
            zaposlenikLabel = new System.Windows.Forms.Label();
            poduzeceLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(63, 54);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(62, 13);
            zaposlenikLabel.TabIndex = 28;
            zaposlenikLabel.Text = "Zaposlenik:";
            // 
            // poduzeceLabel
            // 
            poduzeceLabel.AutoSize = true;
            poduzeceLabel.Location = new System.Drawing.Point(66, 81);
            poduzeceLabel.Name = "poduzeceLabel";
            poduzeceLabel.Size = new System.Drawing.Size(58, 13);
            poduzeceLabel.TabIndex = 29;
            poduzeceLabel.Text = "Poduzeće:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(42, 109);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(83, 13);
            datum_pocetkaLabel.TabIndex = 30;
            datum_pocetkaLabel.Text = "Datum početka:";
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(35, 135);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(90, 13);
            datum_zavrsetkaLabel.TabIndex = 31;
            datum_zavrsetkaLabel.Text = "Datum završetka:";
            // 
            // NaslovZaposlen
            // 
            this.NaslovZaposlen.AutoSize = true;
            this.NaslovZaposlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlen.Location = new System.Drawing.Point(12, 9);
            this.NaslovZaposlen.Name = "NaslovZaposlen";
            this.NaslovZaposlen.Size = new System.Drawing.Size(213, 26);
            this.NaslovZaposlen.TabIndex = 13;
            this.NaslovZaposlen.Text = "Radnik - Poduzeće";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 27;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 169);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // zaposlenikComboBox
            // 
            this.zaposlenikComboBox.FormattingEnabled = true;
            this.zaposlenikComboBox.Location = new System.Drawing.Point(129, 51);
            this.zaposlenikComboBox.Name = "zaposlenikComboBox";
            this.zaposlenikComboBox.Size = new System.Drawing.Size(134, 21);
            this.zaposlenikComboBox.TabIndex = 29;
            this.zaposlenikComboBox.SelectedIndexChanged += new System.EventHandler(this.zaposlenikComboBox_SelectedIndexChanged);
            // 
            // poduzeceComboBox
            // 
            this.poduzeceComboBox.FormattingEnabled = true;
            this.poduzeceComboBox.Location = new System.Drawing.Point(129, 78);
            this.poduzeceComboBox.Name = "poduzeceComboBox";
            this.poduzeceComboBox.Size = new System.Drawing.Size(134, 21);
            this.poduzeceComboBox.TabIndex = 30;
            this.poduzeceComboBox.SelectedIndexChanged += new System.EventHandler(this.poduzeceComboBox_SelectedIndexChanged);
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(129, 105);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.datum_pocetkaDateTimePicker.TabIndex = 31;
            this.datum_pocetkaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_pocetkaDateTimePicker_ValueChanged);
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(129, 131);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.ShowCheckBox = true;
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 32;
            this.datum_zavrsetkaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_zavrsetkaDateTimePicker_ValueChanged);
            // 
            // UpozorenjeZaposlenik
            // 
            this.UpozorenjeZaposlenik.AutoSize = true;
            this.UpozorenjeZaposlenik.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeZaposlenik.Location = new System.Drawing.Point(269, 51);
            this.UpozorenjeZaposlenik.Name = "UpozorenjeZaposlenik";
            this.UpozorenjeZaposlenik.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeZaposlenik.TabIndex = 33;
            this.UpozorenjeZaposlenik.Text = "label1";
            this.UpozorenjeZaposlenik.Visible = false;
            // 
            // UpozorenjePoduzece
            // 
            this.UpozorenjePoduzece.AutoSize = true;
            this.UpozorenjePoduzece.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePoduzece.Location = new System.Drawing.Point(269, 78);
            this.UpozorenjePoduzece.Name = "UpozorenjePoduzece";
            this.UpozorenjePoduzece.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjePoduzece.TabIndex = 34;
            this.UpozorenjePoduzece.Text = "label1";
            this.UpozorenjePoduzece.Visible = false;
            // 
            // UpozorenjeRazlikaDatuma
            // 
            this.UpozorenjeRazlikaDatuma.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRazlikaDatuma.Location = new System.Drawing.Point(269, 105);
            this.UpozorenjeRazlikaDatuma.Name = "UpozorenjeRazlikaDatuma";
            this.UpozorenjeRazlikaDatuma.Size = new System.Drawing.Size(92, 43);
            this.UpozorenjeRazlikaDatuma.TabIndex = 35;
            this.UpozorenjeRazlikaDatuma.Text = "Datum završetka mora biti veći od datuma početka";
            this.UpozorenjeRazlikaDatuma.Visible = false;
            // 
            // frmZaposen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
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
            this.Name = "frmZaposen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovZaposlen;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.ComboBox zaposlenikComboBox;
        private System.Windows.Forms.ComboBox poduzeceComboBox;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
        private System.Windows.Forms.Label UpozorenjeZaposlenik;
        private System.Windows.Forms.Label UpozorenjePoduzece;
        private System.Windows.Forms.Label UpozorenjeRazlikaDatuma;
    }
}