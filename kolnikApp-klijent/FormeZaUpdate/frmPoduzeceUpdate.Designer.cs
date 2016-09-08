namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmPoduzeceUpdate
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
            System.Windows.Forms.Label ibanLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label oibLabel;
            this.UpozorenjeIban = new System.Windows.Forms.Label();
            this.UpozorenjeAdresa = new System.Windows.Forms.Label();
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            this.UpozorenjeOib = new System.Windows.Forms.Label();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.NaslovPoduzece = new System.Windows.Forms.Label();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            ibanLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            oibLabel = new System.Windows.Forms.Label();
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
            // ibanLabel
            // 
            ibanLabel.AutoSize = true;
            ibanLabel.Location = new System.Drawing.Point(93, 132);
            ibanLabel.Name = "ibanLabel";
            ibanLabel.Size = new System.Drawing.Size(35, 13);
            ibanLabel.TabIndex = 42;
            ibanLabel.Text = "IBAN:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(81, 106);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 40;
            adresaLabel.Text = "Adresa:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 80);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 38;
            nazivLabel.Text = "Naziv:";
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(99, 54);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(28, 13);
            oibLabel.TabIndex = 37;
            oibLabel.Text = "OIB:";
            // 
            // UpozorenjeIban
            // 
            this.UpozorenjeIban.AutoSize = true;
            this.UpozorenjeIban.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIban.Location = new System.Drawing.Point(270, 129);
            this.UpozorenjeIban.Name = "UpozorenjeIban";
            this.UpozorenjeIban.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIban.TabIndex = 48;
            this.UpozorenjeIban.Text = "label1";
            this.UpozorenjeIban.Visible = false;
            // 
            // UpozorenjeAdresa
            // 
            this.UpozorenjeAdresa.AutoSize = true;
            this.UpozorenjeAdresa.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeAdresa.Location = new System.Drawing.Point(270, 103);
            this.UpozorenjeAdresa.Name = "UpozorenjeAdresa";
            this.UpozorenjeAdresa.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeAdresa.TabIndex = 47;
            this.UpozorenjeAdresa.Text = "label1";
            this.UpozorenjeAdresa.Visible = false;
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(270, 77);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNaziv.TabIndex = 46;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // UpozorenjeOib
            // 
            this.UpozorenjeOib.AutoSize = true;
            this.UpozorenjeOib.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeOib.Location = new System.Drawing.Point(270, 51);
            this.UpozorenjeOib.Name = "UpozorenjeOib";
            this.UpozorenjeOib.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeOib.TabIndex = 45;
            this.UpozorenjeOib.Text = "label1";
            this.UpozorenjeOib.Visible = false;
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Location = new System.Drawing.Point(129, 129);
            this.ibanTextBox.MaxLength = 34;
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(135, 20);
            this.ibanTextBox.TabIndex = 44;
            this.ibanTextBox.Leave += new System.EventHandler(this.ibanTextBox_Leave);
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(129, 103);
            this.adresaTextBox.MaxLength = 100;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(135, 20);
            this.adresaTextBox.TabIndex = 43;
            this.adresaTextBox.Leave += new System.EventHandler(this.adresaTextBox_Leave);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 77);
            this.nazivTextBox.MaxLength = 100;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(135, 20);
            this.nazivTextBox.TabIndex = 41;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(129, 51);
            this.oibTextBox.MaxLength = 11;
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(135, 20);
            this.oibTextBox.TabIndex = 39;
            this.oibTextBox.Leave += new System.EventHandler(this.oibTextBox_Leave);
            // 
            // NaslovPoduzece
            // 
            this.NaslovPoduzece.AutoSize = true;
            this.NaslovPoduzece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovPoduzece.Location = new System.Drawing.Point(12, 9);
            this.NaslovPoduzece.Name = "NaslovPoduzece";
            this.NaslovPoduzece.Size = new System.Drawing.Size(117, 26);
            this.NaslovPoduzece.TabIndex = 36;
            this.NaslovPoduzece.Text = "Poduzeće";
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 168);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 34;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 168);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 33;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // frmPoduzeceUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeIban);
            this.Controls.Add(this.UpozorenjeAdresa);
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(this.UpozorenjeOib);
            this.Controls.Add(ibanLabel);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(oibLabel);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.NaslovPoduzece);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmPoduzeceUpdate";
            this.Text = "frmPoduzeceUpdate";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.NaslovPoduzece, 0);
            this.Controls.SetChildIndex(this.oibTextBox, 0);
            this.Controls.SetChildIndex(oibLabel, 0);
            this.Controls.SetChildIndex(this.nazivTextBox, 0);
            this.Controls.SetChildIndex(nazivLabel, 0);
            this.Controls.SetChildIndex(this.adresaTextBox, 0);
            this.Controls.SetChildIndex(adresaLabel, 0);
            this.Controls.SetChildIndex(this.ibanTextBox, 0);
            this.Controls.SetChildIndex(ibanLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeOib, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNaziv, 0);
            this.Controls.SetChildIndex(this.UpozorenjeAdresa, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIban, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeIban;
        private System.Windows.Forms.Label UpozorenjeAdresa;
        private System.Windows.Forms.Label UpozorenjeNaziv;
        private System.Windows.Forms.Label UpozorenjeOib;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.Label NaslovPoduzece;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
    }
}