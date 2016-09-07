namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmOsoba
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
            this.NaslovZaposlenik = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.UpozorenjeOib = new System.Windows.Forms.Label();
            this.UpozorenjeIme = new System.Windows.Forms.Label();
            this.UpozorenjePrezime = new System.Windows.Forms.Label();
            this.UpozorenjeLozinka = new System.Windows.Forms.Label();
            this.UpozorenjeKorIme = new System.Windows.Forms.Label();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            oibLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            LozinkaLabel = new System.Windows.Forms.Label();
            KorisnickoImeLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Location = new System.Drawing.Point(2, 2);
            this.controlBox.Size = new System.Drawing.Size(535, 33);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(415, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(456, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(498, 0);
            // 
            // NaslovZaposlenik
            // 
            this.NaslovZaposlenik.AutoSize = true;
            this.NaslovZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlenik.Location = new System.Drawing.Point(16, 11);
            this.NaslovZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovZaposlenik.Name = "NaslovZaposlenik";
            this.NaslovZaposlenik.Size = new System.Drawing.Size(156, 31);
            this.NaslovZaposlenik.TabIndex = 13;
            this.NaslovZaposlenik.Text = "Zaposlenik";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(352, 236);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(244, 236);
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
            this.GumbPotvrda.Location = new System.Drawing.Point(136, 236);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(172, 63);
            this.oibTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.oibTextBox.MaxLength = 11;
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(167, 22);
            this.oibTextBox.TabIndex = 29;
            this.oibTextBox.Leave += new System.EventHandler(this.oibTextBox_Leave);
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(172, 95);
            this.imeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeTextBox.MaxLength = 45;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(167, 22);
            this.imeTextBox.TabIndex = 30;
            this.imeTextBox.Leave += new System.EventHandler(this.imeTextBox_Leave);
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(172, 127);
            this.prezimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prezimeTextBox.MaxLength = 45;
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(167, 22);
            this.prezimeTextBox.TabIndex = 31;
            this.prezimeTextBox.Leave += new System.EventHandler(this.prezimeTextBox_Leave);
            // 
            // UpozorenjeOib
            // 
            this.UpozorenjeOib.AutoSize = true;
            this.UpozorenjeOib.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOib.Location = new System.Drawing.Point(348, 63);
            this.UpozorenjeOib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeOib.Name = "UpozorenjeOib";
            this.UpozorenjeOib.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeOib.TabIndex = 32;
            this.UpozorenjeOib.Text = "label1";
            this.UpozorenjeOib.Visible = false;
            // 
            // UpozorenjeIme
            // 
            this.UpozorenjeIme.AutoSize = true;
            this.UpozorenjeIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIme.Location = new System.Drawing.Point(348, 95);
            this.UpozorenjeIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeIme.Name = "UpozorenjeIme";
            this.UpozorenjeIme.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeIme.TabIndex = 33;
            this.UpozorenjeIme.Text = "label1";
            this.UpozorenjeIme.Visible = false;
            // 
            // UpozorenjePrezime
            // 
            this.UpozorenjePrezime.AutoSize = true;
            this.UpozorenjePrezime.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePrezime.Location = new System.Drawing.Point(348, 127);
            this.UpozorenjePrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjePrezime.Name = "UpozorenjePrezime";
            this.UpozorenjePrezime.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjePrezime.TabIndex = 34;
            this.UpozorenjePrezime.Text = "label1";
            this.UpozorenjePrezime.Visible = false;
            // 
            // UpozorenjeLozinka
            // 
            this.UpozorenjeLozinka.AutoSize = true;
            this.UpozorenjeLozinka.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeLozinka.Location = new System.Drawing.Point(348, 191);
            this.UpozorenjeLozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeLozinka.Name = "UpozorenjeLozinka";
            this.UpozorenjeLozinka.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeLozinka.TabIndex = 40;
            this.UpozorenjeLozinka.Text = "label1";
            this.UpozorenjeLozinka.Visible = false;
            // 
            // UpozorenjeKorIme
            // 
            this.UpozorenjeKorIme.AutoSize = true;
            this.UpozorenjeKorIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeKorIme.Location = new System.Drawing.Point(348, 159);
            this.UpozorenjeKorIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeKorIme.Name = "UpozorenjeKorIme";
            this.UpozorenjeKorIme.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeKorIme.TabIndex = 39;
            this.UpozorenjeKorIme.Text = "label1";
            this.UpozorenjeKorIme.Visible = false;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(172, 191);
            this.lozinkaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTextBox.MaxLength = 45;
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(167, 22);
            this.lozinkaTextBox.TabIndex = 38;
            this.lozinkaTextBox.Leave += new System.EventHandler(this.lozinkaTextBox_Leave);
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(172, 159);
            this.korisnickoImeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.korisnickoImeTextBox.MaxLength = 45;
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(167, 22);
            this.korisnickoImeTextBox.TabIndex = 37;
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(132, 66);
            oibLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(35, 17);
            oibLabel.TabIndex = 28;
            oibLabel.Text = "OIB:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(129, 98);
            imeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 29;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(103, 130);
            prezimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(63, 17);
            prezimeLabel.TabIndex = 30;
            prezimeLabel.Text = "Prezime:";
            // 
            // LozinkaLabel
            // 
            LozinkaLabel.AutoSize = true;
            LozinkaLabel.Location = new System.Drawing.Point(103, 194);
            LozinkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LozinkaLabel.Name = "LozinkaLabel";
            LozinkaLabel.Size = new System.Drawing.Size(61, 17);
            LozinkaLabel.TabIndex = 36;
            LozinkaLabel.Text = "Lozinka:";
            // 
            // KorisnickoImeLabel
            // 
            KorisnickoImeLabel.AutoSize = true;
            KorisnickoImeLabel.Location = new System.Drawing.Point(60, 162);
            KorisnickoImeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            KorisnickoImeLabel.Name = "KorisnickoImeLabel";
            KorisnickoImeLabel.Size = new System.Drawing.Size(103, 17);
            KorisnickoImeLabel.TabIndex = 35;
            KorisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // frmOsoba
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
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
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovZaposlenik);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.Name = "frmOsoba";
            this.Text = "frmZaposlenik";
            this.Controls.SetChildIndex(this.NaslovZaposlenik, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.oibTextBox, 0);
            this.Controls.SetChildIndex(oibLabel, 0);
            this.Controls.SetChildIndex(this.imeTextBox, 0);
            this.Controls.SetChildIndex(imeLabel, 0);
            this.Controls.SetChildIndex(this.prezimeTextBox, 0);
            this.Controls.SetChildIndex(prezimeLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeOib, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIme, 0);
            this.Controls.SetChildIndex(this.UpozorenjePrezime, 0);
            this.Controls.SetChildIndex(this.korisnickoImeTextBox, 0);
            this.Controls.SetChildIndex(KorisnickoImeLabel, 0);
            this.Controls.SetChildIndex(this.lozinkaTextBox, 0);
            this.Controls.SetChildIndex(LozinkaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeKorIme, 0);
            this.Controls.SetChildIndex(this.UpozorenjeLozinka, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovZaposlenik;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Label UpozorenjeOib;
        private System.Windows.Forms.Label UpozorenjeIme;
        private System.Windows.Forms.Label UpozorenjePrezime;
        private System.Windows.Forms.Label UpozorenjeLozinka;
        private System.Windows.Forms.Label UpozorenjeKorIme;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label oibLabel;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label LozinkaLabel;
        private System.Windows.Forms.Label KorisnickoImeLabel;
    }
}