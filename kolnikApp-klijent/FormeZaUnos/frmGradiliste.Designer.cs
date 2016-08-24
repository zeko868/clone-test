namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmGradiliste
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
            System.Windows.Forms.Label naziv_mjestaLabel;
            this.naziv_mjestaTextBox = new System.Windows.Forms.TextBox();
            this.NaslovGradiliste = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.UpozorenjeNazivMjesta = new System.Windows.Forms.Label();
            naziv_mjestaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naziv_mjestaLabel
            // 
            naziv_mjestaLabel.AutoSize = true;
            naziv_mjestaLabel.Location = new System.Drawing.Point(48, 57);
            naziv_mjestaLabel.Name = "naziv_mjestaLabel";
            naziv_mjestaLabel.Size = new System.Drawing.Size(70, 13);
            naziv_mjestaLabel.TabIndex = 1;
            naziv_mjestaLabel.Text = "Naziv mjesta:";
            // 
            // naziv_mjestaTextBox
            // 
            this.naziv_mjestaTextBox.Location = new System.Drawing.Point(122, 54);
            this.naziv_mjestaTextBox.MaxLength = 45;
            this.naziv_mjestaTextBox.Name = "naziv_mjestaTextBox";
            this.naziv_mjestaTextBox.Size = new System.Drawing.Size(114, 20);
            this.naziv_mjestaTextBox.TabIndex = 2;
            this.naziv_mjestaTextBox.Leave += new System.EventHandler(this.naziv_mjestaTextBox_Leave);
            // 
            // NaslovGradiliste
            // 
            this.NaslovGradiliste.AutoSize = true;
            this.NaslovGradiliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovGradiliste.Location = new System.Drawing.Point(12, 9);
            this.NaslovGradiliste.Name = "NaslovGradiliste";
            this.NaslovGradiliste.Size = new System.Drawing.Size(114, 26);
            this.NaslovGradiliste.TabIndex = 7;
            this.NaslovGradiliste.Text = "Gradilište";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 90);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 90);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 90);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 10;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // UpozorenjeNazivMjesta
            // 
            this.UpozorenjeNazivMjesta.AutoSize = true;
            this.UpozorenjeNazivMjesta.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNazivMjesta.Location = new System.Drawing.Point(242, 54);
            this.UpozorenjeNazivMjesta.Name = "UpozorenjeNazivMjesta";
            this.UpozorenjeNazivMjesta.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNazivMjesta.TabIndex = 13;
            this.UpozorenjeNazivMjesta.Text = "label1";
            this.UpozorenjeNazivMjesta.Visible = false;
            // 
            // frmGradiliste
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeNazivMjesta);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovGradiliste);
            this.Controls.Add(naziv_mjestaLabel);
            this.Controls.Add(this.naziv_mjestaTextBox);
            this.Name = "frmGradiliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGradiliste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox naziv_mjestaTextBox;
        private System.Windows.Forms.Label NaslovGradiliste;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label UpozorenjeNazivMjesta;
    }
}