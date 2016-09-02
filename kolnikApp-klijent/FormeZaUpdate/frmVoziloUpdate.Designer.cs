namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmVoziloUpdate
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
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label proizvodjacLabel;
            System.Windows.Forms.Label registracijski_brojLabel;
            this.UpozorenjeModel = new System.Windows.Forms.Label();
            this.UpozorenjeProizvodac = new System.Windows.Forms.Label();
            this.UpozorenjeRegistracijskiBroj = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.proizvodjacTextBox = new System.Windows.Forms.TextBox();
            this.registracijski_brojTextBox = new System.Windows.Forms.TextBox();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovVozilo = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            registracijski_brojLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(85, 106);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 40;
            modelLabel.Text = "Model:";
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(59, 80);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(64, 13);
            proizvodjacLabel.TabIndex = 38;
            proizvodjacLabel.Text = "Proizvođač:";
            // 
            // registracijski_brojLabel
            // 
            registracijski_brojLabel.AutoSize = true;
            registracijski_brojLabel.Location = new System.Drawing.Point(36, 54);
            registracijski_brojLabel.Name = "registracijski_brojLabel";
            registracijski_brojLabel.Size = new System.Drawing.Size(92, 13);
            registracijski_brojLabel.TabIndex = 37;
            registracijski_brojLabel.Text = "Registracijski broj:";
            // 
            // UpozorenjeModel
            // 
            this.UpozorenjeModel.AutoSize = true;
            this.UpozorenjeModel.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeModel.Location = new System.Drawing.Point(262, 103);
            this.UpozorenjeModel.Name = "UpozorenjeModel";
            this.UpozorenjeModel.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeModel.TabIndex = 45;
            this.UpozorenjeModel.Text = "label1";
            this.UpozorenjeModel.Visible = false;
            // 
            // UpozorenjeProizvodac
            // 
            this.UpozorenjeProizvodac.AutoSize = true;
            this.UpozorenjeProizvodac.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeProizvodac.Location = new System.Drawing.Point(262, 77);
            this.UpozorenjeProizvodac.Name = "UpozorenjeProizvodac";
            this.UpozorenjeProizvodac.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeProizvodac.TabIndex = 44;
            this.UpozorenjeProizvodac.Text = "label1";
            this.UpozorenjeProizvodac.Visible = false;
            // 
            // UpozorenjeRegistracijskiBroj
            // 
            this.UpozorenjeRegistracijskiBroj.AutoSize = true;
            this.UpozorenjeRegistracijskiBroj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRegistracijskiBroj.Location = new System.Drawing.Point(262, 51);
            this.UpozorenjeRegistracijskiBroj.Name = "UpozorenjeRegistracijskiBroj";
            this.UpozorenjeRegistracijskiBroj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeRegistracijskiBroj.TabIndex = 43;
            this.UpozorenjeRegistracijskiBroj.Text = "label1";
            this.UpozorenjeRegistracijskiBroj.Visible = false;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(129, 103);
            this.modelTextBox.MaxLength = 45;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(127, 20);
            this.modelTextBox.TabIndex = 42;
            this.modelTextBox.Leave += new System.EventHandler(this.modelTextBox_Leave);
            // 
            // proizvodjacTextBox
            // 
            this.proizvodjacTextBox.Location = new System.Drawing.Point(129, 77);
            this.proizvodjacTextBox.MaxLength = 45;
            this.proizvodjacTextBox.Name = "proizvodjacTextBox";
            this.proizvodjacTextBox.Size = new System.Drawing.Size(127, 20);
            this.proizvodjacTextBox.TabIndex = 41;
            this.proizvodjacTextBox.Leave += new System.EventHandler(this.proizvodjacTextBox_Leave);
            // 
            // registracijski_brojTextBox
            // 
            this.registracijski_brojTextBox.Location = new System.Drawing.Point(129, 51);
            this.registracijski_brojTextBox.MaxLength = 8;
            this.registracijski_brojTextBox.Name = "registracijski_brojTextBox";
            this.registracijski_brojTextBox.Size = new System.Drawing.Size(127, 20);
            this.registracijski_brojTextBox.TabIndex = 39;
            this.registracijski_brojTextBox.Leave += new System.EventHandler(this.registracijski_brojTextBox_Leave);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 36;
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
            this.GumbIzlaz.TabIndex = 35;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 34;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovVozilo
            // 
            this.NaslovVozilo.AutoSize = true;
            this.NaslovVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovVozilo.Location = new System.Drawing.Point(12, 9);
            this.NaslovVozilo.Name = "NaslovVozilo";
            this.NaslovVozilo.Size = new System.Drawing.Size(78, 26);
            this.NaslovVozilo.TabIndex = 33;
            this.NaslovVozilo.Text = "Vozilo";
            // 
            // frmVoziloUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeModel);
            this.Controls.Add(this.UpozorenjeProizvodac);
            this.Controls.Add(this.UpozorenjeRegistracijskiBroj);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(proizvodjacLabel);
            this.Controls.Add(this.proizvodjacTextBox);
            this.Controls.Add(registracijski_brojLabel);
            this.Controls.Add(this.registracijski_brojTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovVozilo);
            this.Name = "frmVoziloUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVoziloUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeModel;
        private System.Windows.Forms.Label UpozorenjeProizvodac;
        private System.Windows.Forms.Label UpozorenjeRegistracijskiBroj;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox proizvodjacTextBox;
        private System.Windows.Forms.TextBox registracijski_brojTextBox;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovVozilo;
    }
}