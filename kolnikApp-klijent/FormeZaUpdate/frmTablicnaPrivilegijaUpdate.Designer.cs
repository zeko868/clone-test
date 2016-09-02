namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmTablicnaPrivilegijaUpdate
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
            System.Windows.Forms.Label operacijaLabel;
            System.Windows.Forms.Label naziv_tabliceLabel;
            System.Windows.Forms.Label radno_mjestoLabel;
            this.UpozorenjeNazivTablice = new System.Windows.Forms.Label();
            this.UpozorenjeRadnoMjesto = new System.Windows.Forms.Label();
            this.naziv_tabliceComboBox = new System.Windows.Forms.ComboBox();
            this.radno_mjestoComboBox = new System.Windows.Forms.ComboBox();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovTablicaPrivilegija = new System.Windows.Forms.Label();
            this.operacijeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            operacijaLabel = new System.Windows.Forms.Label();
            naziv_tabliceLabel = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operacijaLabel
            // 
            operacijaLabel.AutoSize = true;
            operacijaLabel.Location = new System.Drawing.Point(93, 133);
            operacijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            operacijaLabel.Name = "operacijaLabel";
            operacijaLabel.Size = new System.Drawing.Size(73, 17);
            operacijaLabel.TabIndex = 40;
            operacijaLabel.Text = "Operacija:";
            // 
            // naziv_tabliceLabel
            // 
            naziv_tabliceLabel.AutoSize = true;
            naziv_tabliceLabel.Location = new System.Drawing.Point(72, 100);
            naziv_tabliceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            naziv_tabliceLabel.Name = "naziv_tabliceLabel";
            naziv_tabliceLabel.Size = new System.Drawing.Size(92, 17);
            naziv_tabliceLabel.TabIndex = 38;
            naziv_tabliceLabel.Text = "Naziv tablice:";
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(71, 66);
            radno_mjestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(99, 17);
            radno_mjestoLabel.TabIndex = 37;
            radno_mjestoLabel.Text = "Radno mjesto:";
            // 
            // UpozorenjeNazivTablice
            // 
            this.UpozorenjeNazivTablice.AutoSize = true;
            this.UpozorenjeNazivTablice.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNazivTablice.Location = new System.Drawing.Point(341, 96);
            this.UpozorenjeNazivTablice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeNazivTablice.Name = "UpozorenjeNazivTablice";
            this.UpozorenjeNazivTablice.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeNazivTablice.TabIndex = 44;
            this.UpozorenjeNazivTablice.Text = "label1";
            this.UpozorenjeNazivTablice.Visible = false;
            // 
            // UpozorenjeRadnoMjesto
            // 
            this.UpozorenjeRadnoMjesto.AutoSize = true;
            this.UpozorenjeRadnoMjesto.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRadnoMjesto.Location = new System.Drawing.Point(341, 63);
            this.UpozorenjeRadnoMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeRadnoMjesto.Name = "UpozorenjeRadnoMjesto";
            this.UpozorenjeRadnoMjesto.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeRadnoMjesto.TabIndex = 43;
            this.UpozorenjeRadnoMjesto.Text = "label1";
            this.UpozorenjeRadnoMjesto.Visible = false;
            // 
            // naziv_tabliceComboBox
            // 
            this.naziv_tabliceComboBox.FormattingEnabled = true;
            this.naziv_tabliceComboBox.Location = new System.Drawing.Point(172, 96);
            this.naziv_tabliceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naziv_tabliceComboBox.Name = "naziv_tabliceComboBox";
            this.naziv_tabliceComboBox.Size = new System.Drawing.Size(160, 24);
            this.naziv_tabliceComboBox.TabIndex = 41;
            this.naziv_tabliceComboBox.SelectedIndexChanged += new System.EventHandler(this.naziv_tabliceComboBox_SelectedIndexChanged);
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(172, 63);
            this.radno_mjestoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(160, 24);
            this.radno_mjestoComboBox.TabIndex = 39;
            this.radno_mjestoComboBox.SelectedIndexChanged += new System.EventHandler(this.radno_mjestoComboBox_SelectedIndexChanged);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 241);
            this.GumbReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(100, 28);
            this.GumbReset.TabIndex = 36;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 241);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 35;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 241);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 34;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovTablicaPrivilegija
            // 
            this.NaslovTablicaPrivilegija.AutoSize = true;
            this.NaslovTablicaPrivilegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablicaPrivilegija.Location = new System.Drawing.Point(16, 11);
            this.NaslovTablicaPrivilegija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovTablicaPrivilegija.Name = "NaslovTablicaPrivilegija";
            this.NaslovTablicaPrivilegija.Size = new System.Drawing.Size(333, 31);
            this.NaslovTablicaPrivilegija.TabIndex = 33;
            this.NaslovTablicaPrivilegija.Text = "Privilegije radnog mjesta";
            // 
            // operacijeCheckedListBox
            // 
            this.operacijeCheckedListBox.FormattingEnabled = true;
            this.operacijeCheckedListBox.Items.AddRange(new object[] {
            "Create",
            "Read",
            "Update",
            "Delete"});
            this.operacijeCheckedListBox.Location = new System.Drawing.Point(173, 133);
            this.operacijeCheckedListBox.Name = "operacijeCheckedListBox";
            this.operacijeCheckedListBox.Size = new System.Drawing.Size(120, 89);
            this.operacijeCheckedListBox.TabIndex = 45;
            // 
            // frmTablicnaPrivilegijaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.ControlBox = false;
            this.Controls.Add(this.operacijeCheckedListBox);
            this.Controls.Add(this.UpozorenjeNazivTablice);
            this.Controls.Add(this.UpozorenjeRadnoMjesto);
            this.Controls.Add(operacijaLabel);
            this.Controls.Add(naziv_tabliceLabel);
            this.Controls.Add(this.naziv_tabliceComboBox);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.radno_mjestoComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTablicaPrivilegija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTablicnaPrivilegijaUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablicaPrivilegijaUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UpozorenjeNazivTablice;
        private System.Windows.Forms.Label UpozorenjeRadnoMjesto;
        private System.Windows.Forms.ComboBox naziv_tabliceComboBox;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovTablicaPrivilegija;
        private System.Windows.Forms.CheckedListBox operacijeCheckedListBox;
    }
}