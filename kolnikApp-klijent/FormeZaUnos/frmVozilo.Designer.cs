namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmVozilo
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
            System.Windows.Forms.Label registracijski_brojLabel;
            System.Windows.Forms.Label proizvodjacLabel;
            System.Windows.Forms.Label modelLabel;
            this.NaslovVozilo = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.registracijski_brojTextBox = new System.Windows.Forms.TextBox();
            this.proizvodjacTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.UpozorenjeRegistracijskiBroj = new System.Windows.Forms.Label();
            this.UpozorenjeProizvodac = new System.Windows.Forms.Label();
            this.UpozorenjeModel = new System.Windows.Forms.Label();
            registracijski_brojLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
<<<<<<< HEAD
            this.controlBox.Location = new System.Drawing.Point(3, 2);
            this.controlBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlBox.Size = new System.Drawing.Size(533, 41);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(373, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Minimize.Size = new System.Drawing.Size(44, 38);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(427, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RestoreDown.Size = new System.Drawing.Size(44, 38);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(483, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
=======
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
>>>>>>> origin/master
            // 
            // registracijski_brojLabel
            // 
            registracijski_brojLabel.AutoSize = true;
            registracijski_brojLabel.Location = new System.Drawing.Point(48, 66);
            registracijski_brojLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            registracijski_brojLabel.Name = "registracijski_brojLabel";
            registracijski_brojLabel.Size = new System.Drawing.Size(123, 17);
            registracijski_brojLabel.TabIndex = 25;
            registracijski_brojLabel.Text = "Registracijski broj:";
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(79, 98);
            proizvodjacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(82, 17);
            proizvodjacLabel.TabIndex = 26;
            proizvodjacLabel.Text = "Proizvođač:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(113, 130);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(50, 17);
            modelLabel.TabIndex = 27;
            modelLabel.Text = "Model:";
            // 
            // NaslovVozilo
            // 
            this.NaslovVozilo.AutoSize = true;
            this.NaslovVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovVozilo.Location = new System.Drawing.Point(16, 11);
            this.NaslovVozilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovVozilo.Name = "NaslovVozilo";
            this.NaslovVozilo.Size = new System.Drawing.Size(94, 31);
            this.NaslovVozilo.TabIndex = 12;
            this.NaslovVozilo.Text = "Vozilo";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 177);
            this.GumbReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(100, 28);
            this.GumbReset.TabIndex = 24;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 177);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 23;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 177);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 22;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // registracijski_brojTextBox
            // 
            this.registracijski_brojTextBox.Location = new System.Drawing.Point(172, 63);
            this.registracijski_brojTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registracijski_brojTextBox.MaxLength = 8;
            this.registracijski_brojTextBox.Name = "registracijski_brojTextBox";
            this.registracijski_brojTextBox.Size = new System.Drawing.Size(168, 22);
            this.registracijski_brojTextBox.TabIndex = 26;
            this.registracijski_brojTextBox.Leave += new System.EventHandler(this.registracijski_brojTextBox_Leave);
            // 
            // proizvodjacTextBox
            // 
            this.proizvodjacTextBox.Location = new System.Drawing.Point(172, 95);
            this.proizvodjacTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proizvodjacTextBox.MaxLength = 45;
            this.proizvodjacTextBox.Name = "proizvodjacTextBox";
            this.proizvodjacTextBox.Size = new System.Drawing.Size(168, 22);
            this.proizvodjacTextBox.TabIndex = 27;
            this.proizvodjacTextBox.Leave += new System.EventHandler(this.proizvodjacTextBox_Leave);
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(172, 127);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelTextBox.MaxLength = 45;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(168, 22);
            this.modelTextBox.TabIndex = 28;
            this.modelTextBox.Leave += new System.EventHandler(this.modelTextBox_Leave);
            // 
            // UpozorenjeRegistracijskiBroj
            // 
            this.UpozorenjeRegistracijskiBroj.AutoSize = true;
            this.UpozorenjeRegistracijskiBroj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRegistracijskiBroj.Location = new System.Drawing.Point(349, 63);
            this.UpozorenjeRegistracijskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeRegistracijskiBroj.Name = "UpozorenjeRegistracijskiBroj";
            this.UpozorenjeRegistracijskiBroj.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeRegistracijskiBroj.TabIndex = 30;
            this.UpozorenjeRegistracijskiBroj.Text = "label1";
            this.UpozorenjeRegistracijskiBroj.Visible = false;
            // 
            // UpozorenjeProizvodac
            // 
            this.UpozorenjeProizvodac.AutoSize = true;
            this.UpozorenjeProizvodac.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeProizvodac.Location = new System.Drawing.Point(349, 95);
            this.UpozorenjeProizvodac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeProizvodac.Name = "UpozorenjeProizvodac";
            this.UpozorenjeProizvodac.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeProizvodac.TabIndex = 31;
            this.UpozorenjeProizvodac.Text = "label1";
            this.UpozorenjeProizvodac.Visible = false;
            // 
            // UpozorenjeModel
            // 
            this.UpozorenjeModel.AutoSize = true;
            this.UpozorenjeModel.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeModel.Location = new System.Drawing.Point(349, 127);
            this.UpozorenjeModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeModel.Name = "UpozorenjeModel";
            this.UpozorenjeModel.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeModel.TabIndex = 32;
            this.UpozorenjeModel.Text = "label1";
            this.UpozorenjeModel.Visible = false;
            // 
            // frmVozilo
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
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
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2560, 1268);
            this.Name = "frmVozilo";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmVozilo";
>>>>>>> origin/master
            this.Text = "frmVozilo";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovVozilo, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.registracijski_brojTextBox, 0);
            this.Controls.SetChildIndex(registracijski_brojLabel, 0);
            this.Controls.SetChildIndex(this.proizvodjacTextBox, 0);
            this.Controls.SetChildIndex(proizvodjacLabel, 0);
            this.Controls.SetChildIndex(this.modelTextBox, 0);
            this.Controls.SetChildIndex(modelLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeRegistracijskiBroj, 0);
            this.Controls.SetChildIndex(this.UpozorenjeProizvodac, 0);
            this.Controls.SetChildIndex(this.UpozorenjeModel, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovVozilo;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox registracijski_brojTextBox;
        private System.Windows.Forms.TextBox proizvodjacTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label UpozorenjeRegistracijskiBroj;
        private System.Windows.Forms.Label UpozorenjeProizvodac;
        private System.Windows.Forms.Label UpozorenjeModel;
    }
}