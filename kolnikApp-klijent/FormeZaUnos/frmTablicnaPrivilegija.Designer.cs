namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmTablicnaPrivilegija
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
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label naziv_tabliceLabel;
            System.Windows.Forms.Label operacijaLabel;
            this.NaslovTablicaPrivilegija = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.radno_mjestoComboBox = new System.Windows.Forms.ComboBox();
            this.naziv_tabliceComboBox = new System.Windows.Forms.ComboBox();
            this.UpozorenjeRadnoMjesto = new System.Windows.Forms.Label();
            this.UpozorenjeNazivTablice = new System.Windows.Forms.Label();
            this.operacijeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.UpozorenjeCheckbox = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            naziv_tabliceLabel = new System.Windows.Forms.Label();
            operacijaLabel = new System.Windows.Forms.Label();
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
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(71, 66);
            radno_mjestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(99, 17);
            radno_mjestoLabel.TabIndex = 19;
            radno_mjestoLabel.Text = "Radno mjesto:";
            // 
            // naziv_tabliceLabel
            // 
            naziv_tabliceLabel.AutoSize = true;
            naziv_tabliceLabel.Location = new System.Drawing.Point(72, 100);
            naziv_tabliceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            naziv_tabliceLabel.Name = "naziv_tabliceLabel";
            naziv_tabliceLabel.Size = new System.Drawing.Size(92, 17);
            naziv_tabliceLabel.TabIndex = 20;
            naziv_tabliceLabel.Text = "Naziv tablice:";
            // 
            // operacijaLabel
            // 
            operacijaLabel.AutoSize = true;
            operacijaLabel.Location = new System.Drawing.Point(93, 133);
            operacijaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            operacijaLabel.Name = "operacijaLabel";
            operacijaLabel.Size = new System.Drawing.Size(73, 17);
            operacijaLabel.TabIndex = 21;
            operacijaLabel.Text = "Operacije:";
            // 
            // NaslovTablicaPrivilegija
            // 
            this.NaslovTablicaPrivilegija.AutoSize = true;
            this.NaslovTablicaPrivilegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablicaPrivilegija.Location = new System.Drawing.Point(16, 11);
            this.NaslovTablicaPrivilegija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovTablicaPrivilegija.Name = "NaslovTablicaPrivilegija";
            this.NaslovTablicaPrivilegija.Size = new System.Drawing.Size(333, 31);
            this.NaslovTablicaPrivilegija.TabIndex = 9;
            this.NaslovTablicaPrivilegija.Text = "Privilegije radnog mjesta";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(349, 241);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(241, 241);
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
            this.GumbPotvrda.Location = new System.Drawing.Point(133, 241);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(172, 63);
            this.radno_mjestoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(160, 24);
            this.radno_mjestoComboBox.TabIndex = 20;
            this.radno_mjestoComboBox.SelectedIndexChanged += new System.EventHandler(this.radno_mjestoComboBox_SelectedIndexChanged);
            // 
            // naziv_tabliceComboBox
            // 
            this.naziv_tabliceComboBox.FormattingEnabled = true;
            this.naziv_tabliceComboBox.Location = new System.Drawing.Point(172, 96);
            this.naziv_tabliceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naziv_tabliceComboBox.Name = "naziv_tabliceComboBox";
            this.naziv_tabliceComboBox.Size = new System.Drawing.Size(160, 24);
            this.naziv_tabliceComboBox.TabIndex = 21;
            this.naziv_tabliceComboBox.SelectedIndexChanged += new System.EventHandler(this.naziv_tabliceComboBox_SelectedIndexChanged);
            // 
            // UpozorenjeRadnoMjesto
            // 
            this.UpozorenjeRadnoMjesto.AutoSize = true;
            this.UpozorenjeRadnoMjesto.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeRadnoMjesto.Location = new System.Drawing.Point(341, 63);
            this.UpozorenjeRadnoMjesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeRadnoMjesto.Name = "UpozorenjeRadnoMjesto";
            this.UpozorenjeRadnoMjesto.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeRadnoMjesto.TabIndex = 30;
            this.UpozorenjeRadnoMjesto.Text = "label1";
            this.UpozorenjeRadnoMjesto.Visible = false;
            // 
            // UpozorenjeNazivTablice
            // 
            this.UpozorenjeNazivTablice.AutoSize = true;
            this.UpozorenjeNazivTablice.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNazivTablice.Location = new System.Drawing.Point(341, 96);
            this.UpozorenjeNazivTablice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeNazivTablice.Name = "UpozorenjeNazivTablice";
            this.UpozorenjeNazivTablice.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeNazivTablice.TabIndex = 31;
            this.UpozorenjeNazivTablice.Text = "label1";
            this.UpozorenjeNazivTablice.Visible = false;
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
            this.operacijeCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operacijeCheckedListBox.Name = "operacijeCheckedListBox";
            this.operacijeCheckedListBox.Size = new System.Drawing.Size(120, 72);
            this.operacijeCheckedListBox.TabIndex = 32;
            this.operacijeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.operacijeCheckedListBox_ItemCheck);
            // 
            // UpozorenjeCheckbox
            // 
            this.UpozorenjeCheckbox.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeCheckbox.Location = new System.Drawing.Point(345, 133);
            this.UpozorenjeCheckbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeCheckbox.Name = "UpozorenjeCheckbox";
            this.UpozorenjeCheckbox.Size = new System.Drawing.Size(124, 38);
            this.UpozorenjeCheckbox.TabIndex = 33;
            this.UpozorenjeCheckbox.Text = "Označite barem jednu opciju";
            this.UpozorenjeCheckbox.Visible = false;
            // 
            // frmTablicnaPrivilegija
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
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
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTablicaPrivilegija);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(2560, 1268);
            this.Name = "frmTablicnaPrivilegija";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmTablicnaPrivilegija";
>>>>>>> origin/master
            this.Text = "frmTablicaPrivilegija";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovTablicaPrivilegija, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
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

        private System.Windows.Forms.Label NaslovTablicaPrivilegija;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.ComboBox naziv_tabliceComboBox;
        private System.Windows.Forms.Label UpozorenjeRadnoMjesto;
        private System.Windows.Forms.Label UpozorenjeNazivTablice;
        private System.Windows.Forms.CheckedListBox operacijeCheckedListBox;
        private System.Windows.Forms.Label UpozorenjeCheckbox;
    }
}