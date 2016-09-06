namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmOtpremnica
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
            System.Windows.Forms.Label temeljnicaLabel;
            System.Windows.Forms.Label datum_otpremeLabel;
            System.Windows.Forms.Label otpremiteljLabel;
            System.Windows.Forms.Label temperaturaLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovOtpremnica = new System.Windows.Forms.Label();
            this.datum_otpremeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otpremiteljComboBox = new System.Windows.Forms.ComboBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.UpozorenjeTemeljnica = new System.Windows.Forms.Label();
            this.temeljnicaComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeOtpremitelj = new System.Windows.Forms.Label();
            this.UpozorenjeTemeperatura = new System.Windows.Forms.Label();
            temeljnicaLabel = new System.Windows.Forms.Label();
            datum_otpremeLabel = new System.Windows.Forms.Label();
            otpremiteljLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(2, 2);
            this.controlBox.Size = new System.Drawing.Size(400, 33);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(280, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(321, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(363, 0);
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(57, 13);
            temeljnicaLabel.TabIndex = 22;
            temeljnicaLabel.Text = "temeljnica:";
            // 
            // datum_otpremeLabel
            // 
            datum_otpremeLabel.AutoSize = true;
            datum_otpremeLabel.Location = new System.Drawing.Point(43, 81);
            datum_otpremeLabel.Name = "datum_otpremeLabel";
            datum_otpremeLabel.Size = new System.Drawing.Size(80, 13);
            datum_otpremeLabel.TabIndex = 23;
            datum_otpremeLabel.Text = "datum otpreme:";
            // 
            // otpremiteljLabel
            // 
            otpremiteljLabel.AutoSize = true;
            otpremiteljLabel.Location = new System.Drawing.Point(66, 106);
            otpremiteljLabel.Name = "otpremiteljLabel";
            otpremiteljLabel.Size = new System.Drawing.Size(57, 13);
            otpremiteljLabel.TabIndex = 25;
            otpremiteljLabel.Text = "otpremitelj:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(57, 133);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(66, 13);
            temperaturaLabel.TabIndex = 26;
            temperaturaLabel.Text = "temperatura:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 18;
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
            this.GumbIzlaz.TabIndex = 17;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovOtpremnica
            // 
            this.NaslovOtpremnica.AutoSize = true;
            this.NaslovOtpremnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovOtpremnica.Location = new System.Drawing.Point(12, 9);
            this.NaslovOtpremnica.Name = "NaslovOtpremnica";
            this.NaslovOtpremnica.Size = new System.Drawing.Size(135, 26);
            this.NaslovOtpremnica.TabIndex = 21;
            this.NaslovOtpremnica.Text = "Otpremnica";
            // 
            // datum_otpremeDateTimePicker
            // 
            this.datum_otpremeDateTimePicker.Location = new System.Drawing.Point(129, 77);
            this.datum_otpremeDateTimePicker.Name = "datum_otpremeDateTimePicker";
            this.datum_otpremeDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.datum_otpremeDateTimePicker.TabIndex = 24;
            // 
            // otpremiteljComboBox
            // 
            this.otpremiteljComboBox.FormattingEnabled = true;
            this.otpremiteljComboBox.Location = new System.Drawing.Point(129, 103);
            this.otpremiteljComboBox.Name = "otpremiteljComboBox";
            this.otpremiteljComboBox.Size = new System.Drawing.Size(143, 21);
            this.otpremiteljComboBox.TabIndex = 26;
            this.otpremiteljComboBox.SelectedIndexChanged += new System.EventHandler(this.otpremiteljComboBox_SelectedIndexChanged);
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.Location = new System.Drawing.Point(129, 130);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(143, 20);
            this.temperaturaTextBox.TabIndex = 27;
            this.temperaturaTextBox.Leave += new System.EventHandler(this.temperaturaTextBox_Leave);
            // 
            // UpozorenjeTemeljnica
            // 
            this.UpozorenjeTemeljnica.AutoSize = true;
            this.UpozorenjeTemeljnica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeljnica.Location = new System.Drawing.Point(278, 50);
            this.UpozorenjeTemeljnica.Name = "UpozorenjeTemeljnica";
            this.UpozorenjeTemeljnica.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeljnica.TabIndex = 28;
            this.UpozorenjeTemeljnica.Text = "label1";
            this.UpozorenjeTemeljnica.Visible = false;
            // 
            // temeljnicaComboBox
            // 
            this.temeljnicaComboBox.FormattingEnabled = true;
            this.temeljnicaComboBox.Location = new System.Drawing.Point(129, 50);
            this.temeljnicaComboBox.Name = "temeljnicaComboBox";
            this.temeljnicaComboBox.Size = new System.Drawing.Size(143, 21);
            this.temeljnicaComboBox.TabIndex = 29;
            this.temeljnicaComboBox.SelectedIndexChanged += new System.EventHandler(this.temeljnicaComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeOtpremitelj
            // 
            this.UpozorenjeOtpremitelj.AutoSize = true;
            this.UpozorenjeOtpremitelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOtpremitelj.Location = new System.Drawing.Point(278, 103);
            this.UpozorenjeOtpremitelj.Name = "UpozorenjeOtpremitelj";
            this.UpozorenjeOtpremitelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeOtpremitelj.TabIndex = 30;
            this.UpozorenjeOtpremitelj.Text = "label1";
            this.UpozorenjeOtpremitelj.Visible = false;
            // 
            // UpozorenjeTemeperatura
            // 
            this.UpozorenjeTemeperatura.AutoSize = true;
            this.UpozorenjeTemeperatura.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeperatura.Location = new System.Drawing.Point(278, 130);
            this.UpozorenjeTemeperatura.Name = "UpozorenjeTemeperatura";
            this.UpozorenjeTemeperatura.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeperatura.TabIndex = 31;
            this.UpozorenjeTemeperatura.Text = "label1";
            this.UpozorenjeTemeperatura.Visible = false;
            // 
            // frmOtpremnica
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.NaslovOtpremnica);
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
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmOtpremnica";
            this.Text = "frmOtpremnica";
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(temeljnicaLabel, 0);
            this.Controls.SetChildIndex(this.datum_otpremeDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_otpremeLabel, 0);
            this.Controls.SetChildIndex(this.otpremiteljComboBox, 0);
            this.Controls.SetChildIndex(otpremiteljLabel, 0);
            this.Controls.SetChildIndex(this.temperaturaTextBox, 0);
            this.Controls.SetChildIndex(temperaturaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeTemeljnica, 0);
            this.Controls.SetChildIndex(this.temeljnicaComboBox, 0);
            this.Controls.SetChildIndex(this.UpozorenjeOtpremitelj, 0);
            this.Controls.SetChildIndex(this.UpozorenjeTemeperatura, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovOtpremnica, 0);
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
        private System.Windows.Forms.Label NaslovOtpremnica;
        private System.Windows.Forms.DateTimePicker datum_otpremeDateTimePicker;
        private System.Windows.Forms.ComboBox otpremiteljComboBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.Label UpozorenjeTemeljnica;
        private System.Windows.Forms.ComboBox temeljnicaComboBox;
        private System.Windows.Forms.Label UpozorenjeOtpremitelj;
        private System.Windows.Forms.Label UpozorenjeTemeperatura;
    }
}