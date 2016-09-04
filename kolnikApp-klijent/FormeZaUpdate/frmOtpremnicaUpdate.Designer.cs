namespace kolnikApp_klijent.FormeZaUpdate
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
            System.Windows.Forms.Label temperaturaLabel;
            System.Windows.Forms.Label otpremiteljLabel;
            System.Windows.Forms.Label datum_otpremeLabel;
            System.Windows.Forms.Label temeljnicaLabel;
            this.UpozorenjeTemeperatura = new System.Windows.Forms.Label();
            this.UpozorenjeOtpremitelj = new System.Windows.Forms.Label();
            this.temeljnicaComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeTemeljnica = new System.Windows.Forms.Label();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.otpremiteljComboBox = new System.Windows.Forms.ComboBox();
            this.datum_otpremeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NaslovOtpremnica = new System.Windows.Forms.Label();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            temperaturaLabel = new System.Windows.Forms.Label();
            otpremiteljLabel = new System.Windows.Forms.Label();
            datum_otpremeLabel = new System.Windows.Forms.Label();
            temeljnicaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(57, 133);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(70, 13);
            temperaturaLabel.TabIndex = 40;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // otpremiteljLabel
            // 
            otpremiteljLabel.AutoSize = true;
            otpremiteljLabel.Location = new System.Drawing.Point(66, 106);
            otpremiteljLabel.Name = "otpremiteljLabel";
            otpremiteljLabel.Size = new System.Drawing.Size(59, 13);
            otpremiteljLabel.TabIndex = 39;
            otpremiteljLabel.Text = "Otpremitelj:";
            // 
            // datum_otpremeLabel
            // 
            datum_otpremeLabel.AutoSize = true;
            datum_otpremeLabel.Location = new System.Drawing.Point(43, 81);
            datum_otpremeLabel.Name = "datum_otpremeLabel";
            datum_otpremeLabel.Size = new System.Drawing.Size(82, 13);
            datum_otpremeLabel.TabIndex = 37;
            datum_otpremeLabel.Text = "Datum otpreme:";
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(61, 13);
            temeljnicaLabel.TabIndex = 36;
            temeljnicaLabel.Text = "Temeljnica:";
            // 
            // UpozorenjeTemeperatura
            // 
            this.UpozorenjeTemeperatura.AutoSize = true;
            this.UpozorenjeTemeperatura.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeperatura.Location = new System.Drawing.Point(278, 130);
            this.UpozorenjeTemeperatura.Name = "UpozorenjeTemeperatura";
            this.UpozorenjeTemeperatura.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeperatura.TabIndex = 46;
            this.UpozorenjeTemeperatura.Text = "label1";
            this.UpozorenjeTemeperatura.Visible = false;
            // 
            // UpozorenjeOtpremitelj
            // 
            this.UpozorenjeOtpremitelj.AutoSize = true;
            this.UpozorenjeOtpremitelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOtpremitelj.Location = new System.Drawing.Point(278, 103);
            this.UpozorenjeOtpremitelj.Name = "UpozorenjeOtpremitelj";
            this.UpozorenjeOtpremitelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeOtpremitelj.TabIndex = 45;
            this.UpozorenjeOtpremitelj.Text = "label1";
            this.UpozorenjeOtpremitelj.Visible = false;
            // 
            // temeljnicaComboBox
            // 
            this.temeljnicaComboBox.FormattingEnabled = true;
            this.temeljnicaComboBox.Location = new System.Drawing.Point(129, 50);
            this.temeljnicaComboBox.Name = "temeljnicaComboBox";
            this.temeljnicaComboBox.Size = new System.Drawing.Size(143, 21);
            this.temeljnicaComboBox.TabIndex = 44;
            this.temeljnicaComboBox.SelectedIndexChanged += new System.EventHandler(this.temeljnicaComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeTemeljnica
            // 
            this.UpozorenjeTemeljnica.AutoSize = true;
            this.UpozorenjeTemeljnica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeljnica.Location = new System.Drawing.Point(278, 50);
            this.UpozorenjeTemeljnica.Name = "UpozorenjeTemeljnica";
            this.UpozorenjeTemeljnica.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeljnica.TabIndex = 43;
            this.UpozorenjeTemeljnica.Text = "label1";
            this.UpozorenjeTemeljnica.Visible = false;
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.Location = new System.Drawing.Point(129, 130);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(143, 20);
            this.temperaturaTextBox.TabIndex = 42;
            this.temperaturaTextBox.Leave += new System.EventHandler(this.temperaturaTextBox_Leave);
            // 
            // otpremiteljComboBox
            // 
            this.otpremiteljComboBox.FormattingEnabled = true;
            this.otpremiteljComboBox.Location = new System.Drawing.Point(129, 103);
            this.otpremiteljComboBox.Name = "otpremiteljComboBox";
            this.otpremiteljComboBox.Size = new System.Drawing.Size(143, 21);
            this.otpremiteljComboBox.TabIndex = 41;
            this.otpremiteljComboBox.SelectedIndexChanged += new System.EventHandler(this.otpremiteljComboBox_SelectedIndexChanged);
            // 
            // datum_otpremeDateTimePicker
            // 
            this.datum_otpremeDateTimePicker.Location = new System.Drawing.Point(129, 77);
            this.datum_otpremeDateTimePicker.Name = "datum_otpremeDateTimePicker";
            this.datum_otpremeDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.datum_otpremeDateTimePicker.TabIndex = 38;
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
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 168);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 33;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 168);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 32;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // frmOtpremnicaUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeTemeperatura);
            this.Controls.Add(this.UpozorenjeOtpremitelj);
            this.Controls.Add(this.temeljnicaComboBox);
            this.Controls.Add(this.UpozorenjeTemeljnica);
            this.Controls.Add(temperaturaLabel);
            this.Controls.Add(this.temperaturaTextBox);
            this.Controls.Add(otpremiteljLabel);
            this.Controls.Add(this.otpremiteljComboBox);
            this.Controls.Add(datum_otpremeLabel);
            this.Controls.Add(this.datum_otpremeDateTimePicker);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.NaslovOtpremnica);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Name = "frmOtpremnicaUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOtpremnicaUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeTemeperatura;
        private System.Windows.Forms.Label UpozorenjeOtpremitelj;
        private System.Windows.Forms.ComboBox temeljnicaComboBox;
        private System.Windows.Forms.Label UpozorenjeTemeljnica;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.ComboBox otpremiteljComboBox;
        private System.Windows.Forms.DateTimePicker datum_otpremeDateTimePicker;
        private System.Windows.Forms.Label NaslovOtpremnica;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
    }
}