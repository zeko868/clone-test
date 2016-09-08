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
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovTablicaPrivilegija = new System.Windows.Forms.Label();
            this.operacijeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.UpozorenjeCheckbox = new System.Windows.Forms.Label();
            operacijaLabel = new System.Windows.Forms.Label();
            naziv_tabliceLabel = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
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
            this.Minimize.Location = new System.Drawing.Point(472, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(512, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(554, 0);
            // 
            // operacijaLabel
            // 
            operacijaLabel.AutoSize = true;
            operacijaLabel.Location = new System.Drawing.Point(70, 108);
            operacijaLabel.Name = "operacijaLabel";
            operacijaLabel.Size = new System.Drawing.Size(55, 13);
            operacijaLabel.TabIndex = 40;
            operacijaLabel.Text = "Operacija:";
            // 
            // naziv_tabliceLabel
            // 
            naziv_tabliceLabel.AutoSize = true;
            naziv_tabliceLabel.Location = new System.Drawing.Point(54, 81);
            naziv_tabliceLabel.Name = "naziv_tabliceLabel";
            naziv_tabliceLabel.Size = new System.Drawing.Size(71, 13);
            naziv_tabliceLabel.TabIndex = 38;
            naziv_tabliceLabel.Text = "Naziv tablice:";
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(53, 54);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(75, 13);
            radno_mjestoLabel.TabIndex = 37;
            radno_mjestoLabel.Text = "Radno mjesto:";
            // 
            // UpozorenjeNazivTablice
            // 
            this.UpozorenjeNazivTablice.AutoSize = true;
            this.UpozorenjeNazivTablice.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNazivTablice.Location = new System.Drawing.Point(256, 78);
            this.UpozorenjeNazivTablice.Name = "UpozorenjeNazivTablice";
            this.UpozorenjeNazivTablice.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNazivTablice.TabIndex = 44;
            this.UpozorenjeNazivTablice.Text = "label1";
            this.UpozorenjeNazivTablice.Visible = false;
            // 
            // UpozorenjeRadnoMjesto
            // 
            this.UpozorenjeRadnoMjesto.AutoSize = true;
            this.UpozorenjeRadnoMjesto.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRadnoMjesto.Location = new System.Drawing.Point(256, 51);
            this.UpozorenjeRadnoMjesto.Name = "UpozorenjeRadnoMjesto";
            this.UpozorenjeRadnoMjesto.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeRadnoMjesto.TabIndex = 43;
            this.UpozorenjeRadnoMjesto.Text = "label1";
            this.UpozorenjeRadnoMjesto.Visible = false;
            // 
            // naziv_tabliceComboBox
            // 
            this.naziv_tabliceComboBox.FormattingEnabled = true;
            this.naziv_tabliceComboBox.Location = new System.Drawing.Point(129, 78);
            this.naziv_tabliceComboBox.Name = "naziv_tabliceComboBox";
            this.naziv_tabliceComboBox.Size = new System.Drawing.Size(121, 21);
            this.naziv_tabliceComboBox.TabIndex = 41;
            this.naziv_tabliceComboBox.SelectedIndexChanged += new System.EventHandler(this.naziv_tabliceComboBox_SelectedIndexChanged);
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(129, 51);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(121, 21);
            this.radno_mjestoComboBox.TabIndex = 39;
            this.radno_mjestoComboBox.SelectedIndexChanged += new System.EventHandler(this.radno_mjestoComboBox_SelectedIndexChanged);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 196);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 35;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 196);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 34;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovTablicaPrivilegija
            // 
            this.NaslovTablicaPrivilegija.AutoSize = true;
            this.NaslovTablicaPrivilegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablicaPrivilegija.Location = new System.Drawing.Point(12, 9);
            this.NaslovTablicaPrivilegija.Name = "NaslovTablicaPrivilegija";
            this.NaslovTablicaPrivilegija.Size = new System.Drawing.Size(275, 26);
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
            this.operacijeCheckedListBox.Location = new System.Drawing.Point(130, 108);
            this.operacijeCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.operacijeCheckedListBox.Name = "operacijeCheckedListBox";
            this.operacijeCheckedListBox.Size = new System.Drawing.Size(120, 64);
            this.operacijeCheckedListBox.TabIndex = 45;
            this.operacijeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.operacijeCheckedListBox_ItemCheck);
            // 
            // UpozorenjeCheckbox
            // 
            this.UpozorenjeCheckbox.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeCheckbox.Location = new System.Drawing.Point(255, 108);
            this.UpozorenjeCheckbox.Name = "UpozorenjeCheckbox";
            this.UpozorenjeCheckbox.Size = new System.Drawing.Size(93, 31);
            this.UpozorenjeCheckbox.TabIndex = 46;
            this.UpozorenjeCheckbox.Text = "Označite barem jednu opciju";
            this.UpozorenjeCheckbox.Visible = false;
            // 
            // frmTablicnaPrivilegijaUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeCheckbox);
            this.Controls.Add(this.operacijeCheckedListBox);
            this.Controls.Add(this.UpozorenjeNazivTablice);
            this.Controls.Add(this.UpozorenjeRadnoMjesto);
            this.Controls.Add(operacijaLabel);
            this.Controls.Add(naziv_tabliceLabel);
            this.Controls.Add(this.naziv_tabliceComboBox);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.radno_mjestoComboBox);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTablicaPrivilegija);
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.Name = "frmTablicnaPrivilegijaUpdate";
            this.Text = "frmTablicaPrivilegijaUpdate";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovTablicaPrivilegija, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.radno_mjestoComboBox, 0);
            this.Controls.SetChildIndex(radno_mjestoLabel, 0);
            this.Controls.SetChildIndex(this.naziv_tabliceComboBox, 0);
            this.Controls.SetChildIndex(naziv_tabliceLabel, 0);
            this.Controls.SetChildIndex(operacijaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeRadnoMjesto, 0);
            this.Controls.SetChildIndex(this.UpozorenjeNazivTablice, 0);
            this.Controls.SetChildIndex(this.operacijeCheckedListBox, 0);
            this.Controls.SetChildIndex(this.UpozorenjeCheckbox, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UpozorenjeNazivTablice;
        private System.Windows.Forms.Label UpozorenjeRadnoMjesto;
        private System.Windows.Forms.ComboBox naziv_tabliceComboBox;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovTablicaPrivilegija;
        private System.Windows.Forms.CheckedListBox operacijeCheckedListBox;
        private System.Windows.Forms.Label UpozorenjeCheckbox;
    }
}