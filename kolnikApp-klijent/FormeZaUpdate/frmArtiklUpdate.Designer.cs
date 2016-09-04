namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmArtiklUpdate
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
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            System.Windows.Forms.Label nazivLabel;
            this.UpozorenjeJedinicnaCijena = new System.Windows.Forms.Label();
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovArtikl = new System.Windows.Forms.Label();
            this.jedinicna_cijenaTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(40, 80);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 15;
            jedinicna_cijenaLabel.Text = "Jedinicna cijena:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 54);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 13;
            nazivLabel.Text = "Naziv:";
            // 
            // UpozorenjeJedinicnaCijena
            // 
            this.UpozorenjeJedinicnaCijena.AutoSize = true;
            this.UpozorenjeJedinicnaCijena.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeJedinicnaCijena.Location = new System.Drawing.Point(236, 77);
            this.UpozorenjeJedinicnaCijena.Name = "UpozorenjeJedinicnaCijena";
            this.UpozorenjeJedinicnaCijena.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeJedinicnaCijena.TabIndex = 24;
            this.UpozorenjeJedinicnaCijena.Text = "label1";
            this.UpozorenjeJedinicnaCijena.Visible = false;
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(236, 51);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNaziv.TabIndex = 23;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 118);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 21;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 118);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 20;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovArtikl
            // 
            this.NaslovArtikl.AutoSize = true;
            this.NaslovArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovArtikl.Location = new System.Drawing.Point(12, 9);
            this.NaslovArtikl.Name = "NaslovArtikl";
            this.NaslovArtikl.Size = new System.Drawing.Size(67, 26);
            this.NaslovArtikl.TabIndex = 19;
            this.NaslovArtikl.Text = "Artikl";
            // 
            // jedinicna_cijenaTextBox
            // 
            this.jedinicna_cijenaTextBox.Location = new System.Drawing.Point(129, 77);
            this.jedinicna_cijenaTextBox.MaxLength = 9;
            this.jedinicna_cijenaTextBox.Name = "jedinicna_cijenaTextBox";
            this.jedinicna_cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinicna_cijenaTextBox.TabIndex = 16;
            this.jedinicna_cijenaTextBox.Leave += new System.EventHandler(this.jedinicna_cijenaTextBox_Leave);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 51);
            this.nazivTextBox.MaxLength = 100;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 14;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // frmArtiklUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeJedinicnaCijena);
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovArtikl);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.jedinicna_cijenaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Name = "frmArtiklUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArtiklUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UpozorenjeJedinicnaCijena;
        private System.Windows.Forms.Label UpozorenjeNaziv;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovArtikl;
        private System.Windows.Forms.TextBox jedinicna_cijenaTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
    }
}