namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmKorisnickiRacunUpdate
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
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label zaposlenikLabel;
            this.UpozorenjeLozinka = new System.Windows.Forms.Label();
            this.UpozorenjeKorisnickoIme = new System.Windows.Forms.Label();
            this.UpozorenjeZaposlenik = new System.Windows.Forms.Label();
            this.zaposlenikComboBox = new System.Windows.Forms.ComboBox();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            this.NaslovKorisnickiRacun = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            zaposlenikLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(76, 106);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            lozinkaLabel.TabIndex = 25;
            lozinkaLabel.Text = "Lozinka:";
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(46, 80);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(78, 13);
            korisnicko_imeLabel.TabIndex = 24;
            korisnicko_imeLabel.Text = "Korisničko ime:";
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(63, 54);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(62, 13);
            zaposlenikLabel.TabIndex = 23;
            zaposlenikLabel.Text = "Zaposlenik:";
            // 
            // UpozorenjeLozinka
            // 
            this.UpozorenjeLozinka.AutoSize = true;
            this.UpozorenjeLozinka.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeLozinka.Location = new System.Drawing.Point(268, 103);
            this.UpozorenjeLozinka.Name = "UpozorenjeLozinka";
            this.UpozorenjeLozinka.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeLozinka.TabIndex = 34;
            this.UpozorenjeLozinka.Text = "label1";
            this.UpozorenjeLozinka.Visible = false;
            // 
            // UpozorenjeKorisnickoIme
            // 
            this.UpozorenjeKorisnickoIme.AutoSize = true;
            this.UpozorenjeKorisnickoIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeKorisnickoIme.Location = new System.Drawing.Point(268, 77);
            this.UpozorenjeKorisnickoIme.Name = "UpozorenjeKorisnickoIme";
            this.UpozorenjeKorisnickoIme.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeKorisnickoIme.TabIndex = 33;
            this.UpozorenjeKorisnickoIme.Text = "label1";
            this.UpozorenjeKorisnickoIme.Visible = false;
            // 
            // UpozorenjeZaposlenik
            // 
            this.UpozorenjeZaposlenik.AutoSize = true;
            this.UpozorenjeZaposlenik.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeZaposlenik.Location = new System.Drawing.Point(268, 50);
            this.UpozorenjeZaposlenik.Name = "UpozorenjeZaposlenik";
            this.UpozorenjeZaposlenik.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeZaposlenik.TabIndex = 32;
            this.UpozorenjeZaposlenik.Text = "label1";
            this.UpozorenjeZaposlenik.Visible = false;
            // 
            // zaposlenikComboBox
            // 
            this.zaposlenikComboBox.FormattingEnabled = true;
            this.zaposlenikComboBox.Location = new System.Drawing.Point(129, 50);
            this.zaposlenikComboBox.Name = "zaposlenikComboBox";
            this.zaposlenikComboBox.Size = new System.Drawing.Size(133, 21);
            this.zaposlenikComboBox.TabIndex = 31;
            this.zaposlenikComboBox.SelectedIndexChanged += new System.EventHandler(this.zaposlenikComboBox_SelectedIndexChanged);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 30;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 29;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 28;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(129, 103);
            this.lozinkaTextBox.MaxLength = 40;
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(133, 20);
            this.lozinkaTextBox.TabIndex = 27;
            this.lozinkaTextBox.Leave += new System.EventHandler(this.lozinkaTextBox_Leave);
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(129, 77);
            this.korisnicko_imeTextBox.MaxLength = 45;
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(133, 20);
            this.korisnicko_imeTextBox.TabIndex = 26;
            this.korisnicko_imeTextBox.Leave += new System.EventHandler(this.korisnicko_imeTextBox_Leave);
            // 
            // NaslovKorisnickiRacun
            // 
            this.NaslovKorisnickiRacun.AutoSize = true;
            this.NaslovKorisnickiRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovKorisnickiRacun.Location = new System.Drawing.Point(12, 9);
            this.NaslovKorisnickiRacun.Name = "NaslovKorisnickiRacun";
            this.NaslovKorisnickiRacun.Size = new System.Drawing.Size(182, 26);
            this.NaslovKorisnickiRacun.TabIndex = 22;
            this.NaslovKorisnickiRacun.Text = "Korisnički račun";
            // 
            // frmKorisnickiRacunUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeLozinka);
            this.Controls.Add(this.UpozorenjeKorisnickoIme);
            this.Controls.Add(this.UpozorenjeZaposlenik);
            this.Controls.Add(this.zaposlenikComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(lozinkaLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.korisnicko_imeTextBox);
            this.Controls.Add(zaposlenikLabel);
            this.Controls.Add(this.NaslovKorisnickiRacun);
            this.Name = "frmKorisnickiRacunUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisnickiRacunUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeLozinka;
        private System.Windows.Forms.Label UpozorenjeKorisnickoIme;
        private System.Windows.Forms.Label UpozorenjeZaposlenik;
        private System.Windows.Forms.ComboBox zaposlenikComboBox;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
        private System.Windows.Forms.Label NaslovKorisnickiRacun;
    }
}