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
            izdavateljLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(36, 54);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(89, 13);
            datum_izdavanjaLabel.TabIndex = 36;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
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
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(129, 77);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(131, 21);
            this.izdavateljComboBox.TabIndex = 39;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 38;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 143);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 34;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 143);
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
            // placenoCheckBox
            // 
            this.placenoCheckBox.AutoSize = true;
            this.placenoCheckBox.Location = new System.Drawing.Point(129, 103);
            this.placenoCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.placenoCheckBox.Name = "placenoCheckBox";
            this.placenoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.placenoCheckBox.TabIndex = 42;
            this.placenoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Plaćeno:";
            // 
            // frmRacunUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
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
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovRacun;
        private System.Windows.Forms.CheckBox placenoCheckBox;
        private System.Windows.Forms.Label label1;
    }
}