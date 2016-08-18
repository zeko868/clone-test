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
            System.Windows.Forms.Label jedinica_mjereLabel;
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.jedinicna_cijenaTextBox = new System.Windows.Forms.TextBox();
            this.jedinica_mjereTextBox = new System.Windows.Forms.TextBox();
            this.NaslovArtikl = new System.Windows.Forms.Label();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbReset = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            jedinicna_cijenaLabel = new System.Windows.Forms.Label();
            jedinica_mjereLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 54);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(35, 13);
            nazivLabel.TabIndex = 0;
            nazivLabel.Text = "naziv:";
            // 
            // jedinicna_cijenaLabel
            // 
            jedinicna_cijenaLabel.AutoSize = true;
            jedinicna_cijenaLabel.Location = new System.Drawing.Point(40, 80);
            jedinicna_cijenaLabel.Name = "jedinicna_cijenaLabel";
            jedinicna_cijenaLabel.Size = new System.Drawing.Size(83, 13);
            jedinicna_cijenaLabel.TabIndex = 2;
            jedinicna_cijenaLabel.Text = "jedinicna cijena:";
            // 
            // jedinica_mjereLabel
            // 
            jedinica_mjereLabel.AutoSize = true;
            jedinica_mjereLabel.Location = new System.Drawing.Point(49, 106);
            jedinica_mjereLabel.Name = "jedinica_mjereLabel";
            jedinica_mjereLabel.Size = new System.Drawing.Size(74, 13);
            jedinica_mjereLabel.TabIndex = 4;
            jedinica_mjereLabel.Text = "jedinica mjere:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(129, 51);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // jedinicna_cijenaTextBox
            // 
            this.jedinicna_cijenaTextBox.Location = new System.Drawing.Point(129, 77);
            this.jedinicna_cijenaTextBox.Name = "jedinicna_cijenaTextBox";
            this.jedinicna_cijenaTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinicna_cijenaTextBox.TabIndex = 3;
            // 
            // jedinica_mjereTextBox
            // 
            this.jedinica_mjereTextBox.Location = new System.Drawing.Point(129, 103);
            this.jedinica_mjereTextBox.Name = "jedinica_mjereTextBox";
            this.jedinica_mjereTextBox.Size = new System.Drawing.Size(100, 20);
            this.jedinica_mjereTextBox.TabIndex = 5;
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
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 7;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 8;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 9;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // frmArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovArtikl);
            this.Controls.Add(jedinica_mjereLabel);
            this.Controls.Add(this.jedinica_mjereTextBox);
            this.Controls.Add(jedinicna_cijenaLabel);
            this.Controls.Add(this.jedinicna_cijenaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Name = "frmArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArtikl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox jedinicna_cijenaTextBox;
        private System.Windows.Forms.TextBox jedinica_mjereTextBox;
        private System.Windows.Forms.Label NaslovArtikl;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbReset;
    }
}