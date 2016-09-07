namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRabat
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
            System.Windows.Forms.Label popustLabel;
            System.Windows.Forms.Label artiklLabel;
            System.Windows.Forms.Label poslovni_partnerLabel;
            this.NaslovRabat = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.popustTextBox = new System.Windows.Forms.TextBox();
            this.artiklComboBox = new System.Windows.Forms.ComboBox();
            this.poslovni_partnerComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeArtikl = new System.Windows.Forms.Label();
            this.UpozorenjePoslovniPartner = new System.Windows.Forms.Label();
            this.UpozorenjePopust = new System.Windows.Forms.Label();
            popustLabel = new System.Windows.Forms.Label();
            artiklLabel = new System.Windows.Forms.Label();
            poslovni_partnerLabel = new System.Windows.Forms.Label();
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
            // popustLabel
            // 
            popustLabel.AutoSize = true;
            popustLabel.Location = new System.Drawing.Point(81, 108);
            popustLabel.Name = "popustLabel";
            popustLabel.Size = new System.Drawing.Size(43, 13);
            popustLabel.TabIndex = 20;
            popustLabel.Text = "Popust:";
            // 
            // artiklLabel
            // 
            artiklLabel.AutoSize = true;
            artiklLabel.Location = new System.Drawing.Point(91, 54);
            artiklLabel.Name = "artiklLabel";
            artiklLabel.Size = new System.Drawing.Size(33, 13);
            artiklLabel.TabIndex = 21;
            artiklLabel.Text = "Artikl:";
            // 
            // poslovni_partnerLabel
            // 
            poslovni_partnerLabel.AutoSize = true;
            poslovni_partnerLabel.Location = new System.Drawing.Point(38, 81);
            poslovni_partnerLabel.Name = "poslovni_partnerLabel";
            poslovni_partnerLabel.Size = new System.Drawing.Size(86, 13);
            poslovni_partnerLabel.TabIndex = 22;
            poslovni_partnerLabel.Text = "Poslovni partner:";
            // 
            // NaslovRabat
            // 
            this.NaslovRabat.AutoSize = true;
            this.NaslovRabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRabat.Location = new System.Drawing.Point(12, 9);
            this.NaslovRabat.Name = "NaslovRabat";
            this.NaslovRabat.Size = new System.Drawing.Size(75, 26);
            this.NaslovRabat.TabIndex = 14;
            this.NaslovRabat.Text = "Rabat";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 17;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 16;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 15;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // popustTextBox
            // 
            this.popustTextBox.Location = new System.Drawing.Point(129, 105);
            this.popustTextBox.MaxLength = 6;
            this.popustTextBox.Name = "popustTextBox";
            this.popustTextBox.Size = new System.Drawing.Size(143, 20);
            this.popustTextBox.TabIndex = 21;
            this.popustTextBox.Leave += new System.EventHandler(this.popustTextBox_Leave);
            // 
            // artiklComboBox
            // 
            this.artiklComboBox.FormattingEnabled = true;
            this.artiklComboBox.Location = new System.Drawing.Point(129, 51);
            this.artiklComboBox.Name = "artiklComboBox";
            this.artiklComboBox.Size = new System.Drawing.Size(143, 21);
            this.artiklComboBox.TabIndex = 22;
            this.artiklComboBox.SelectedIndexChanged += new System.EventHandler(this.artiklComboBox_SelectedIndexChanged);
            // 
            // poslovni_partnerComboBox
            // 
            this.poslovni_partnerComboBox.FormattingEnabled = true;
            this.poslovni_partnerComboBox.Location = new System.Drawing.Point(129, 78);
            this.poslovni_partnerComboBox.Name = "poslovni_partnerComboBox";
            this.poslovni_partnerComboBox.Size = new System.Drawing.Size(143, 21);
            this.poslovni_partnerComboBox.TabIndex = 23;
            this.poslovni_partnerComboBox.SelectedIndexChanged += new System.EventHandler(this.poslovni_partnerComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeArtikl
            // 
            this.UpozorenjeArtikl.AutoSize = true;
            this.UpozorenjeArtikl.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeArtikl.Location = new System.Drawing.Point(278, 51);
            this.UpozorenjeArtikl.Name = "UpozorenjeArtikl";
            this.UpozorenjeArtikl.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeArtikl.TabIndex = 29;
            this.UpozorenjeArtikl.Text = "label1";
            this.UpozorenjeArtikl.Visible = false;
            // 
            // UpozorenjePoslovniPartner
            // 
            this.UpozorenjePoslovniPartner.AutoSize = true;
            this.UpozorenjePoslovniPartner.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePoslovniPartner.Location = new System.Drawing.Point(278, 78);
            this.UpozorenjePoslovniPartner.Name = "UpozorenjePoslovniPartner";
            this.UpozorenjePoslovniPartner.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjePoslovniPartner.TabIndex = 30;
            this.UpozorenjePoslovniPartner.Text = "label1";
            this.UpozorenjePoslovniPartner.Visible = false;
            // 
            // UpozorenjePopust
            // 
            this.UpozorenjePopust.AutoSize = true;
            this.UpozorenjePopust.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePopust.Location = new System.Drawing.Point(278, 105);
            this.UpozorenjePopust.Name = "UpozorenjePopust";
            this.UpozorenjePopust.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjePopust.TabIndex = 31;
            this.UpozorenjePopust.Text = "label1";
            this.UpozorenjePopust.Visible = false;
            // 
            // frmRabat
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjePopust);
            this.Controls.Add(this.UpozorenjePoslovniPartner);
            this.Controls.Add(this.UpozorenjeArtikl);
            this.Controls.Add(poslovni_partnerLabel);
            this.Controls.Add(this.poslovni_partnerComboBox);
            this.Controls.Add(artiklLabel);
            this.Controls.Add(this.artiklComboBox);
            this.Controls.Add(popustLabel);
            this.Controls.Add(this.popustTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRabat);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmRabat";
            this.Text = "frmRabat";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovRabat, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.popustTextBox, 0);
            this.Controls.SetChildIndex(popustLabel, 0);
            this.Controls.SetChildIndex(this.artiklComboBox, 0);
            this.Controls.SetChildIndex(artiklLabel, 0);
            this.Controls.SetChildIndex(this.poslovni_partnerComboBox, 0);
            this.Controls.SetChildIndex(poslovni_partnerLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeArtikl, 0);
            this.Controls.SetChildIndex(this.UpozorenjePoslovniPartner, 0);
            this.Controls.SetChildIndex(this.UpozorenjePopust, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRabat;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox popustTextBox;
        private System.Windows.Forms.ComboBox artiklComboBox;
        private System.Windows.Forms.ComboBox poslovni_partnerComboBox;
        private System.Windows.Forms.Label UpozorenjeArtikl;
        private System.Windows.Forms.Label UpozorenjePoslovniPartner;
        private System.Windows.Forms.Label UpozorenjePopust;
    }
}