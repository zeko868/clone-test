namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmArtikl
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label jedinicna_cijenaLabel;
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.jedinicna_cijenaTextBox = new System.Windows.Forms.TextBox();
            this.NaslovArtikl = new System.Windows.Forms.Label();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbReset = new System.Windows.Forms.Button();
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            this.UpozorenjeJedinicnaCijena = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
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
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 54);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "Naziv:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(40, 80);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(86, 13);
            jedinicna_cijenaLabel.TabIndex = 2;
            jedinicna_cijenaLabel.Text = "Jedinicna cijena:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 51);
            this.nazivTextBox.MaxLength = 100;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 1;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // jedinicna_cijenaTextBox
            // 
            this.jedinicna_cijenaTextBox.Location = new System.Drawing.Point(129, 77);
            this.jedinicna_cijenaTextBox.MaxLength = 9;
            this.jedinicna_cijenaTextBox.Name = "jedinicna_cijenaTextBox";
            this.jedinicna_cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinicna_cijenaTextBox.TabIndex = 3;
            this.jedinicna_cijenaTextBox.Leave += new System.EventHandler(this.jedinicna_cijenaTextBox_Leave);
            // 
            // NaslovArtikl
            // 
            this.NaslovArtikl.AutoSize = true;
            this.NaslovArtikl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovArtikl.Location = new System.Drawing.Point(12, 9);
            this.NaslovArtikl.Name = "NaslovArtikl";
            this.NaslovArtikl.Size = new System.Drawing.Size(67, 26);
            this.NaslovArtikl.TabIndex = 6;
            this.NaslovArtikl.Text = "Artikl";
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 118);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 7;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 118);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 8;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 118);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 9;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(236, 51);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNaziv.TabIndex = 10;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // UpozorenjeJedinicnaCijena
            // 
            this.UpozorenjeJedinicnaCijena.AutoSize = true;
            this.UpozorenjeJedinicnaCijena.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeJedinicnaCijena.Location = new System.Drawing.Point(236, 77);
            this.UpozorenjeJedinicnaCijena.Name = "UpozorenjeJedinicnaCijena";
            this.UpozorenjeJedinicnaCijena.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeJedinicnaCijena.TabIndex = 11;
            this.UpozorenjeJedinicnaCijena.Text = "label1";
            this.UpozorenjeJedinicnaCijena.Visible = false;
            // 
            // frmArtikl
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeJedinicnaCijena);
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovArtikl);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.jedinicna_cijenaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmArtikl";
            this.Text = "frmArtikl";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.nazivTextBox, 0);
            this.Controls.SetChildIndex(nazivLabel, 0);
            this.Controls.SetChildIndex(this.jedinicna_cijenaTextBox, 0);
            this.Controls.SetChildIndex(jedinicna_cijenaLabel, 0);
            this.Controls.SetChildIndex(this.NaslovArtikl, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNaziv, 0);
            this.Controls.SetChildIndex(this.UpozorenjeJedinicnaCijena, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox jedinicna_cijenaTextBox;
        private System.Windows.Forms.Label NaslovArtikl;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Label UpozorenjeNaziv;
        private System.Windows.Forms.Label UpozorenjeJedinicnaCijena;
    }
}