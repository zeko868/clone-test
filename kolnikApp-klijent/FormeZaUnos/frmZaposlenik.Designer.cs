namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmZaposlenik
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
            System.Windows.Forms.Label oibLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
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
            oibLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(99, 54);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(28, 13);
            oibLabel.TabIndex = 28;
            oibLabel.Text = "OIB:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(97, 80);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 29;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(77, 106);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 30;
            prezimeLabel.Text = "Prezime:";
            // 
            // NaslovZaposlenik
            // 
            this.NaslovZaposlenik.AutoSize = true;
            this.NaslovZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlenik.Location = new System.Drawing.Point(12, 9);
            this.NaslovZaposlenik.Name = "NaslovZaposlenik";
            this.NaslovZaposlenik.Size = new System.Drawing.Size(127, 26);
            this.NaslovZaposlenik.TabIndex = 13;
            this.NaslovZaposlenik.Text = "Zaposlenik";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(129, 51);
            this.oibTextBox.MaxLength = 11;
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(126, 20);
            this.oibTextBox.TabIndex = 29;
            this.oibTextBox.Leave += new System.EventHandler(this.oibTextBox_Leave);
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(129, 77);
            this.imeTextBox.MaxLength = 45;
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(126, 20);
            this.imeTextBox.TabIndex = 30;
            this.imeTextBox.Leave += new System.EventHandler(this.imeTextBox_Leave);
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(129, 103);
            this.prezimeTextBox.MaxLength = 45;
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(126, 20);
            this.prezimeTextBox.TabIndex = 31;
            this.prezimeTextBox.Leave += new System.EventHandler(this.prezimeTextBox_Leave);
            // 
            // UpozorenjeOib
            // 
            this.UpozorenjeOib.AutoSize = true;
            this.UpozorenjeOib.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOib.Location = new System.Drawing.Point(261, 51);
            this.UpozorenjeOib.Name = "UpozorenjeOib";
            this.UpozorenjeOib.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeOib.TabIndex = 32;
            this.UpozorenjeOib.Text = "label1";
            this.UpozorenjeOib.Visible = false;
            // 
            // UpozorenjeIme
            // 
            this.UpozorenjeIme.AutoSize = true;
            this.UpozorenjeIme.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIme.Location = new System.Drawing.Point(261, 77);
            this.UpozorenjeIme.Name = "UpozorenjeIme";
            this.UpozorenjeIme.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIme.TabIndex = 33;
            this.UpozorenjeIme.Text = "label1";
            this.UpozorenjeIme.Visible = false;
            // 
            // UpozorenjePrezime
            // 
            this.UpozorenjePrezime.AutoSize = true;
            this.UpozorenjePrezime.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjePrezime.Location = new System.Drawing.Point(261, 103);
            this.UpozorenjePrezime.Name = "UpozorenjePrezime";
            this.UpozorenjePrezime.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjePrezime.TabIndex = 34;
            this.UpozorenjePrezime.Text = "label1";
            this.UpozorenjePrezime.Visible = false;
            // 
            // frmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbPotvrda;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
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
            this.Name = "frmZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposlenik";
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
    }
}