namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRadnoMjesto
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
            this.NaslovRadnoMjesto = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.UpozorenjeNaziv = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
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
            nazivLabel.Location = new System.Drawing.Point(117, 66);
            nazivLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(47, 17);
            nazivLabel.TabIndex = 19;
            nazivLabel.Text = "Naziv:";
            // 
            // NaslovRadnoMjesto
            // 
            this.NaslovRadnoMjesto.AutoSize = true;
            this.NaslovRadnoMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRadnoMjesto.Location = new System.Drawing.Point(16, 11);
            this.NaslovRadnoMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovRadnoMjesto.Name = "NaslovRadnoMjesto";
            this.NaslovRadnoMjesto.Size = new System.Drawing.Size(193, 31);
            this.NaslovRadnoMjesto.TabIndex = 9;
            this.NaslovRadnoMjesto.Text = "Radno mjesto";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 111);
            this.GumbReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(100, 28);
            this.GumbReset.TabIndex = 18;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 111);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 17;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 111);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(172, 63);
            this.nazivTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nazivTextBox.MaxLength = 45;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(132, 22);
            this.nazivTextBox.TabIndex = 20;
            this.nazivTextBox.Leave += new System.EventHandler(this.nazivTextBox_Leave);
            // 
            // UpozorenjeNaziv
            // 
            this.UpozorenjeNaziv.AutoSize = true;
            this.UpozorenjeNaziv.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNaziv.Location = new System.Drawing.Point(313, 63);
            this.UpozorenjeNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeNaziv.Name = "UpozorenjeNaziv";
            this.UpozorenjeNaziv.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeNaziv.TabIndex = 30;
            this.UpozorenjeNaziv.Text = "label1";
            this.UpozorenjeNaziv.Visible = false;
            // 
            // frmRadnoMjesto
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeNaziv);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRadnoMjesto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2560, 1268);
            this.Name = "frmRadnoMjesto";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Text = "frmRadnoMjesto";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovRadnoMjesto, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.nazivTextBox, 0);
            this.Controls.SetChildIndex(nazivLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNaziv, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRadnoMjesto;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label UpozorenjeNaziv;
    }
}