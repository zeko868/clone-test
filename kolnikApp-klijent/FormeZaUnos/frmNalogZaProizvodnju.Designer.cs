namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmNalogZaProizvodnju
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
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label gradilisteLabel;
            this.NaslovNalogZaProizvodnju = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.gradilisteComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeTemeljnica = new System.Windows.Forms.Label();
            this.UpozorenjeGradiliste = new System.Windows.Forms.Label();
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.temeljnicaComboBox = new System.Windows.Forms.ComboBox();
            temeljnicaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            gradilisteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(61, 13);
            temeljnicaLabel.TabIndex = 13;
            temeljnicaLabel.Text = "Temeljnica:";
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(69, 106);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(55, 13);
            izdavateljLabel.TabIndex = 15;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // gradilisteLabel
            // 
            gradilisteLabel.AutoSize = true;
            gradilisteLabel.Location = new System.Drawing.Point(72, 80);
            gradilisteLabel.Name = "gradilisteLabel";
            gradilisteLabel.Size = new System.Drawing.Size(53, 13);
            gradilisteLabel.TabIndex = 16;
            gradilisteLabel.Text = "Gradiliste:";
            // 
            // NaslovNalogZaProizvodnju
            // 
            this.NaslovNalogZaProizvodnju.AutoSize = true;
            this.NaslovNalogZaProizvodnju.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovNalogZaProizvodnju.Location = new System.Drawing.Point(12, 9);
            this.NaslovNalogZaProizvodnju.Name = "NaslovNalogZaProizvodnju";
            this.NaslovNalogZaProizvodnju.Size = new System.Drawing.Size(235, 26);
            this.NaslovNalogZaProizvodnju.TabIndex = 7;
            this.NaslovNalogZaProizvodnju.Text = "Nalog za proizvodnju";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 12;
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
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 10;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(129, 103);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(121, 21);
            this.izdavateljComboBox.TabIndex = 16;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // gradilisteComboBox
            // 
            this.gradilisteComboBox.FormattingEnabled = true;
            this.gradilisteComboBox.Location = new System.Drawing.Point(129, 77);
            this.gradilisteComboBox.Name = "gradilisteComboBox";
            this.gradilisteComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradilisteComboBox.TabIndex = 17;
            this.gradilisteComboBox.SelectedIndexChanged += new System.EventHandler(this.gradilisteComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeTemeljnica
            // 
            this.UpozorenjeTemeljnica.AutoSize = true;
            this.UpozorenjeTemeljnica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeljnica.Location = new System.Drawing.Point(256, 51);
            this.UpozorenjeTemeljnica.Name = "UpozorenjeTemeljnica";
            this.UpozorenjeTemeljnica.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeljnica.TabIndex = 20;
            this.UpozorenjeTemeljnica.Text = "label1";
            this.UpozorenjeTemeljnica.Visible = false;
            // 
            // UpozorenjeGradiliste
            // 
            this.UpozorenjeGradiliste.AutoSize = true;
            this.UpozorenjeGradiliste.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeGradiliste.Location = new System.Drawing.Point(256, 77);
            this.UpozorenjeGradiliste.Name = "UpozorenjeGradiliste";
            this.UpozorenjeGradiliste.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeGradiliste.TabIndex = 21;
            this.UpozorenjeGradiliste.Text = "label1";
            this.UpozorenjeGradiliste.Visible = false;
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(256, 103);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIzdavatelj.TabIndex = 22;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // temeljnicaComboBox
            // 
            this.temeljnicaComboBox.FormattingEnabled = true;
            this.temeljnicaComboBox.Location = new System.Drawing.Point(129, 51);
            this.temeljnicaComboBox.Name = "temeljnicaComboBox";
            this.temeljnicaComboBox.Size = new System.Drawing.Size(121, 21);
            this.temeljnicaComboBox.TabIndex = 23;
            this.temeljnicaComboBox.SelectedIndexChanged += new System.EventHandler(this.temeljnicaComboBox_SelectedIndexChanged);
            // 
            // frmNalogZaProizvodnju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.temeljnicaComboBox);
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(this.UpozorenjeGradiliste);
            this.Controls.Add(this.UpozorenjeTemeljnica);
            this.Controls.Add(gradilisteLabel);
            this.Controls.Add(this.gradilisteComboBox);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovNalogZaProizvodnju);
            this.Name = "frmNalogZaProizvodnju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNalogZaProizvodnju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovNalogZaProizvodnju;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.ComboBox gradilisteComboBox;
        private System.Windows.Forms.Label UpozorenjeTemeljnica;
        private System.Windows.Forms.Label UpozorenjeGradiliste;
        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.ComboBox temeljnicaComboBox;
    }
}