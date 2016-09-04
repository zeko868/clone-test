namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmZaposlenikUpdate
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
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label oibLabel;
            System.Windows.Forms.Label LozinkaLabel;
            System.Windows.Forms.Label KorisnickoImeLabel;
            this.UpozorenjePrezime = new System.Windows.Forms.Label();
            this.UpozorenjeIme = new System.Windows.Forms.Label();
            this.UpozorenjeOib = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovZaposlenik = new System.Windows.Forms.Label();
            this.UpozorenjeLozinka = new System.Windows.Forms.Label();
            this.UpozorenjeKorIme = new System.Windows.Forms.Label();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            prezimeLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            oibLabel = new System.Windows.Forms.Label();
            LozinkaLabel = new System.Windows.Forms.Label();
            KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(77, 106);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 42;
            prezimeLabel.Text = "Prezime:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(97, 80);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 40;
            imeLabel.Text = "Ime:";
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(99, 54);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(28, 13);
            oibLabel.TabIndex = 39;
            oibLabel.Text = "OIB:";
            // 
            // LozinkaLabel
            // 
            LozinkaLabel.AutoSize = true;
            LozinkaLabel.Location = new System.Drawing.Point(77, 158);
            LozinkaLabel.Name = "LozinkaLabel";
            LozinkaLabel.Size = new System.Drawing.Size(47, 13);
            LozinkaLabel.TabIndex = 49;
            LozinkaLabel.Text = "Lozinka:";
            // 
            // KorisnickoImeLabel
            // 
            KorisnickoImeLabel.AutoSize = true;
            KorisnickoImeLabel.Location = new System.Drawing.Point(45, 132);
            KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            KorisnickoImeLabel.Size = new System.Drawing.Size(78, 13);
            KorisnickoImeLabel.TabIndex = 48;
            KorisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // UpozorenjePrezime
            // 
            this.UpozorenjePrezime.AutoSize = true;
            this.UpozorenjePrezime.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePrezime.Location = new System.Drawing.Point(261, 103);
            this.UpozorenjePrezime.Name = "UpozorenjePrezime";
            this.UpozorenjePrezime.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjePrezime.TabIndex = 47;
            this.UpozorenjePrezime.Text = "label1";
            this.UpozorenjePrezime.Visible = false;
            // 
            // UpozorenjeIme
            // 
            this.UpozorenjeIme.AutoSize = true;
            this.UpozorenjeIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIme.Location = new System.Drawing.Point(261, 77);
            this.UpozorenjeIme.Name = "UpozorenjeIme";
            this.UpozorenjeIme.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIme.TabIndex = 46;
            this.UpozorenjeIme.Text = "label1";
            this.UpozorenjeIme.Visible = false;
            // 
            // UpozorenjeOib
            // 
            this.UpozorenjeOib.AutoSize = true;
            this.UpozorenjeOib.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOib.Location = new System.Drawing.Point(261, 51);
            this.UpozorenjeOib.Name = "UpozorenjeOib";
            this.UpozorenjeOib.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeOib.TabIndex = 45;
            this.UpozorenjeOib.Text = "label1";
            this.UpozorenjeOib.Visible = false;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(129, 103);
            this.prezimeTextBox.MaxLength = 45;
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(126, 20);
            this.prezimeTextBox.TabIndex = 44;
            this.prezimeTextBox.Leave += new System.EventHandler(this.prezimeTextBox_Leave);
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(129, 77);
            this.imeTextBox.MaxLength = 45;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(126, 20);
            this.imeTextBox.TabIndex = 43;
            this.imeTextBox.Leave += new System.EventHandler(this.imeTextBox_Leave);
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(129, 51);
            this.oibTextBox.MaxLength = 11;
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(126, 20);
            this.oibTextBox.TabIndex = 41;
            this.oibTextBox.Leave += new System.EventHandler(this.oibTextBox_Leave);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 192);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 37;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 192);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 36;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovZaposlenik
            // 
            this.NaslovZaposlenik.AutoSize = true;
            this.NaslovZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlenik.Location = new System.Drawing.Point(12, 9);
            this.NaslovZaposlenik.Name = "NaslovZaposlenik";
            this.NaslovZaposlenik.Size = new System.Drawing.Size(127, 26);
            this.NaslovZaposlenik.TabIndex = 35;
            this.NaslovZaposlenik.Text = "Zaposlenik";
            // 
            // UpozorenjeLozinka
            // 
            this.UpozorenjeLozinka.AutoSize = true;
            this.UpozorenjeLozinka.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeLozinka.Location = new System.Drawing.Point(261, 155);
            this.UpozorenjeLozinka.Name = "UpozorenjeLozinka";
            this.UpozorenjeLozinka.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeLozinka.TabIndex = 53;
            this.UpozorenjeLozinka.Text = "label1";
            this.UpozorenjeLozinka.Visible = false;
            // 
            // UpozorenjeKorIme
            // 
            this.UpozorenjeKorIme.AutoSize = true;
            this.UpozorenjeKorIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeKorIme.Location = new System.Drawing.Point(261, 129);
            this.UpozorenjeKorIme.Name = "UpozorenjeKorIme";
            this.UpozorenjeKorIme.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeKorIme.TabIndex = 52;
            this.UpozorenjeKorIme.Text = "label1";
            this.UpozorenjeKorIme.Visible = false;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(129, 155);
            this.lozinkaTextBox.MaxLength = 45;
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(126, 20);
            this.lozinkaTextBox.TabIndex = 51;
            this.lozinkaTextBox.Leave += new System.EventHandler(this.lozinkaTextBox_Leave);
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(129, 129);
            this.korisnickoImeTextBox.MaxLength = 45;
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(126, 20);
            this.korisnickoImeTextBox.TabIndex = 50;
            this.korisnickoImeTextBox.Leave += new System.EventHandler(this.korisnickoImeTextBox_Leave);
            // 
            // frmZaposlenikUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeLozinka);
            this.Controls.Add(this.UpozorenjeKorIme);
            this.Controls.Add(LozinkaLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(KorisnickoImeLabel);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.UpozorenjePrezime);
            this.Controls.Add(this.UpozorenjeIme);
            this.Controls.Add(this.UpozorenjeOib);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(oibLabel);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovZaposlenik);
            this.Name = "frmZaposlenikUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposlenikUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjePrezime;
        private System.Windows.Forms.Label UpozorenjeIme;
        private System.Windows.Forms.Label UpozorenjeOib;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovZaposlenik;
        private System.Windows.Forms.Label UpozorenjeLozinka;
        private System.Windows.Forms.Label UpozorenjeKorIme;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
    }
}