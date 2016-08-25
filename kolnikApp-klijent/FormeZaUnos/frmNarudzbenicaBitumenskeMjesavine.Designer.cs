namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmNarudzbenicaBitumenskeMjesavine
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
            System.Windows.Forms.Label datum_potrazivanjaLabel;
            System.Windows.Forms.Label naruciteljLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.datum_potrazivanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.naruciteljComboBox = new System.Windows.Forms.ComboBox();
            this.NaslovNarudzbenica = new System.Windows.Forms.Label();
            this.UpozorenjeTemeljnica = new System.Windows.Forms.Label();
            this.UpozorenjeDatumPotrazivanja = new System.Windows.Forms.Label();
            this.UpozorenjeNarucitelj = new System.Windows.Forms.Label();
            this.temeljnicaComboBox = new System.Windows.Forms.ComboBox();
            temeljnicaLabel = new System.Windows.Forms.Label();
            datum_potrazivanjaLabel = new System.Windows.Forms.Label();
            naruciteljLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(61, 13);
            temeljnicaLabel.TabIndex = 16;
            temeljnicaLabel.Text = "Temeljnica:";
            // 
            // datum_potrazivanjaLabel
            // 
            datum_potrazivanjaLabel.AutoSize = true;
            datum_potrazivanjaLabel.Location = new System.Drawing.Point(24, 81);
            datum_potrazivanjaLabel.Name = "datum_potrazivanjaLabel";
            datum_potrazivanjaLabel.Size = new System.Drawing.Size(101, 13);
            datum_potrazivanjaLabel.TabIndex = 17;
            datum_potrazivanjaLabel.Text = "Datum potrazivanja:";
            // 
            // naruciteljLabel
            // 
            naruciteljLabel.AutoSize = true;
            naruciteljLabel.Location = new System.Drawing.Point(71, 106);
            naruciteljLabel.Name = "naruciteljLabel";
            naruciteljLabel.Size = new System.Drawing.Size(54, 13);
            naruciteljLabel.TabIndex = 18;
            naruciteljLabel.Text = "Narucitelj:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 15;
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
            this.GumbIzlaz.TabIndex = 14;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 13;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // datum_potrazivanjaDateTimePicker
            // 
            this.datum_potrazivanjaDateTimePicker.Location = new System.Drawing.Point(129, 77);
            this.datum_potrazivanjaDateTimePicker.Name = "datum_potrazivanjaDateTimePicker";
            this.datum_potrazivanjaDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.datum_potrazivanjaDateTimePicker.TabIndex = 18;
            // 
            // naruciteljComboBox
            // 
            this.naruciteljComboBox.FormattingEnabled = true;
            this.naruciteljComboBox.Location = new System.Drawing.Point(129, 103);
            this.naruciteljComboBox.Name = "naruciteljComboBox";
            this.naruciteljComboBox.Size = new System.Drawing.Size(138, 21);
            this.naruciteljComboBox.TabIndex = 19;
            this.naruciteljComboBox.SelectedIndexChanged += new System.EventHandler(this.naruciteljComboBox_SelectedIndexChanged);
            // 
            // NaslovNarudzbenica
            // 
            this.NaslovNarudzbenica.AutoSize = true;
            this.NaslovNarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovNarudzbenica.Location = new System.Drawing.Point(12, 9);
            this.NaslovNarudzbenica.Name = "NaslovNarudzbenica";
            this.NaslovNarudzbenica.Size = new System.Drawing.Size(158, 26);
            this.NaslovNarudzbenica.TabIndex = 20;
            this.NaslovNarudzbenica.Text = "Narudžbenica";
            // 
            // UpozorenjeTemeljnica
            // 
            this.UpozorenjeTemeljnica.AutoSize = true;
            this.UpozorenjeTemeljnica.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeTemeljnica.Location = new System.Drawing.Point(273, 51);
            this.UpozorenjeTemeljnica.Name = "UpozorenjeTemeljnica";
            this.UpozorenjeTemeljnica.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeTemeljnica.TabIndex = 21;
            this.UpozorenjeTemeljnica.Text = "label1";
            this.UpozorenjeTemeljnica.Visible = false;
            // 
            // UpozorenjeDatumPotrazivanja
            // 
            this.UpozorenjeDatumPotrazivanja.AutoSize = true;
            this.UpozorenjeDatumPotrazivanja.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumPotrazivanja.Location = new System.Drawing.Point(273, 77);
            this.UpozorenjeDatumPotrazivanja.Name = "UpozorenjeDatumPotrazivanja";
            this.UpozorenjeDatumPotrazivanja.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeDatumPotrazivanja.TabIndex = 22;
            this.UpozorenjeDatumPotrazivanja.Text = "label1";
            this.UpozorenjeDatumPotrazivanja.Visible = false;
            // 
            // UpozorenjeNarucitelj
            // 
            this.UpozorenjeNarucitelj.AutoSize = true;
            this.UpozorenjeNarucitelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeNarucitelj.Location = new System.Drawing.Point(273, 103);
            this.UpozorenjeNarucitelj.Name = "UpozorenjeNarucitelj";
            this.UpozorenjeNarucitelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeNarucitelj.TabIndex = 23;
            this.UpozorenjeNarucitelj.Text = "label1";
            this.UpozorenjeNarucitelj.Visible = false;
            // 
            // temeljnicaComboBox
            // 
            this.temeljnicaComboBox.FormattingEnabled = true;
            this.temeljnicaComboBox.Location = new System.Drawing.Point(129, 51);
            this.temeljnicaComboBox.Name = "temeljnicaComboBox";
            this.temeljnicaComboBox.Size = new System.Drawing.Size(138, 21);
            this.temeljnicaComboBox.TabIndex = 24;
            this.temeljnicaComboBox.SelectedIndexChanged += new System.EventHandler(this.temeljnicaComboBox_SelectedIndexChanged);
            // 
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.ControlBox = false;
            this.Controls.Add(this.temeljnicaComboBox);
            this.Controls.Add(this.UpozorenjeNarucitelj);
            this.Controls.Add(this.UpozorenjeDatumPotrazivanja);
            this.Controls.Add(this.UpozorenjeTemeljnica);
            this.Controls.Add(this.NaslovNarudzbenica);
            this.Controls.Add(naruciteljLabel);
            this.Controls.Add(this.naruciteljComboBox);
            this.Controls.Add(datum_potrazivanjaLabel);
            this.Controls.Add(this.datum_potrazivanjaDateTimePicker);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Name = "frmNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNarudzbenica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.DateTimePicker datum_potrazivanjaDateTimePicker;
        private System.Windows.Forms.ComboBox naruciteljComboBox;
        private System.Windows.Forms.Label NaslovNarudzbenica;
        private System.Windows.Forms.Label UpozorenjeTemeljnica;
        private System.Windows.Forms.Label UpozorenjeDatumPotrazivanja;
        private System.Windows.Forms.Label UpozorenjeNarucitelj;
        private System.Windows.Forms.ComboBox temeljnicaComboBox;
    }
}