﻿namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmOtpremnicaUpdate
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
            System.Windows.Forms.Label datum_otpremeLabel;
            System.Windows.Forms.Label NarudzbenicaLabel;
            this.NaslovOtpremnica = new System.Windows.Forms.Label();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.narudzbenicaComboBox = new System.Windows.Forms.ComboBox();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.datum_otpremeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.UpozorenjeNarudzbenica = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            datum_otpremeLabel = new System.Windows.Forms.Label();
            NarudzbenicaLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(2, 2);
            this.controlBox.Size = new System.Drawing.Size(486, 33);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(1596, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(1637, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1679, 0);
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(26, 108);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(55, 13);
            izdavateljLabel.TabIndex = 34;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // datum_otpremeLabel
            // 
            datum_otpremeLabel.AutoSize = true;
            datum_otpremeLabel.Location = new System.Drawing.Point(3, 83);
            datum_otpremeLabel.Name = "datum_otpremeLabel";
            datum_otpremeLabel.Size = new System.Drawing.Size(82, 13);
            datum_otpremeLabel.TabIndex = 32;
            datum_otpremeLabel.Text = "Datum otpreme:";
            // 
            // NarudzbenicaLabel
            // 
            NarudzbenicaLabel.AutoSize = true;
            NarudzbenicaLabel.Location = new System.Drawing.Point(7, 55);
            NarudzbenicaLabel.Name = "NarudzbenicaLabel";
            NarudzbenicaLabel.Size = new System.Drawing.Size(76, 13);
            NarudzbenicaLabel.TabIndex = 31;
            NarudzbenicaLabel.Text = "Narudžbenica:";
            // 
            // NaslovOtpremnica
            // 
            this.NaslovOtpremnica.AutoSize = true;
            this.NaslovOtpremnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovOtpremnica.Location = new System.Drawing.Point(12, 9);
            this.NaslovOtpremnica.Name = "NaslovOtpremnica";
            this.NaslovOtpremnica.Size = new System.Drawing.Size(135, 26);
            this.NaslovOtpremnica.TabIndex = 35;
            this.NaslovOtpremnica.Text = "Otpremnica";
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(170, 152);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 33;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(89, 152);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 32;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // narudzbenicaComboBox
            // 
            this.narudzbenicaComboBox.FormattingEnabled = true;
            this.narudzbenicaComboBox.Location = new System.Drawing.Point(89, 52);
            this.narudzbenicaComboBox.Name = "narudzbenicaComboBox";
            this.narudzbenicaComboBox.Size = new System.Drawing.Size(307, 21);
            this.narudzbenicaComboBox.TabIndex = 37;
            this.narudzbenicaComboBox.SelectedIndexChanged += new System.EventHandler(this.narudzbenicaComboBox_SelectedIndexChanged);
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(89, 105);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(307, 21);
            this.izdavateljComboBox.TabIndex = 35;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // datum_otpremeDateTimePicker
            // 
            this.datum_otpremeDateTimePicker.Location = new System.Drawing.Point(89, 79);
            this.datum_otpremeDateTimePicker.Name = "datum_otpremeDateTimePicker";
            this.datum_otpremeDateTimePicker.Size = new System.Drawing.Size(307, 20);
            this.datum_otpremeDateTimePicker.TabIndex = 33;
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(402, 101);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(66, 29);
            this.UpozorenjeIzdavatelj.TabIndex = 42;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // UpozorenjeNarudzbenica
            // 
            this.UpozorenjeNarudzbenica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpozorenjeNarudzbenica.Location = new System.Drawing.Point(402, 47);
            this.UpozorenjeNarudzbenica.Name = "UpozorenjeNarudzbenica";
            this.UpozorenjeNarudzbenica.Size = new System.Drawing.Size(66, 29);
            this.UpozorenjeNarudzbenica.TabIndex = 41;
            this.UpozorenjeNarudzbenica.Text = "label1";
            this.UpozorenjeNarudzbenica.Visible = false;
            // 
            // frmOtpremnicaUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(490, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(this.UpozorenjeNarudzbenica);
            this.Controls.Add(this.NaslovOtpremnica);
            this.Controls.Add(this.narudzbenicaComboBox);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(datum_otpremeLabel);
            this.Controls.Add(NarudzbenicaLabel);
            this.Controls.Add(this.datum_otpremeDateTimePicker);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmOtpremnicaUpdate";
            this.Text = "frmOtpremnicaUpdate";
            this.Controls.SetChildIndex(this.datum_otpremeDateTimePicker, 0);
            this.Controls.SetChildIndex(NarudzbenicaLabel, 0);
            this.Controls.SetChildIndex(datum_otpremeLabel, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.izdavateljComboBox, 0);
            this.Controls.SetChildIndex(izdavateljLabel, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.narudzbenicaComboBox, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovOtpremnica, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNarudzbenica, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIzdavatelj, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NaslovOtpremnica;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.ComboBox narudzbenicaComboBox;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.DateTimePicker datum_otpremeDateTimePicker;
        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.Label UpozorenjeNarudzbenica;
    }
}