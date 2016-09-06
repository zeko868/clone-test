namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmNarudzbenicaBitumenskeMjesavineUpdate
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
            System.Windows.Forms.Label artiklLabel;
            System.Windows.Forms.Label voziLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label datum_izdavanjaLabel;
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label datum_potrazivanjaLabel;
            this.NaslovNarudzbenica = new System.Windows.Forms.Label();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.UpozorenjeArtikl = new System.Windows.Forms.Label();
            this.UpozorenjeVozi = new System.Windows.Forms.Label();
            this.UpozorenjeKolicina = new System.Windows.Forms.Label();
            this.UpozorenjeDatumi = new System.Windows.Forms.Label();
            this.artiklComboBox = new System.Windows.Forms.ComboBox();
            this.voziComboBox = new System.Windows.Forms.ComboBox();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpozorenjeIzdavatelj = new System.Windows.Forms.Label();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.datum_potrazivanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            artiklLabel = new System.Windows.Forms.Label();
            voziLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            datum_potrazivanjaLabel = new System.Windows.Forms.Label();
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
            this.Minimize.Location = new System.Drawing.Point(524, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(565, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(607, 0);
            // 
            // artiklLabel
            // 
            artiklLabel.AutoSize = true;
            artiklLabel.Location = new System.Drawing.Point(93, 135);
            artiklLabel.Name = "artiklLabel";
            artiklLabel.Size = new System.Drawing.Size(33, 13);
            artiklLabel.TabIndex = 60;
            artiklLabel.Text = "Artikl:";
            // 
            // voziLabel
            // 
            voziLabel.AutoSize = true;
            voziLabel.Location = new System.Drawing.Point(93, 162);
            voziLabel.Name = "voziLabel";
            voziLabel.Size = new System.Drawing.Size(30, 13);
            voziLabel.TabIndex = 59;
            voziLabel.Text = "Vozi:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(79, 189);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(47, 13);
            kolicinaLabel.TabIndex = 56;
            kolicinaLabel.Text = "Količina:";
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(38, 58);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(89, 13);
            datum_izdavanjaLabel.TabIndex = 55;
            datum_izdavanjaLabel.Text = "Datum izdavanja:";
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(73, 109);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(55, 13);
            izdavateljLabel.TabIndex = 52;
            izdavateljLabel.Text = "Izdavatelj:";
            // 
            // datum_potrazivanjaLabel
            // 
            datum_potrazivanjaLabel.AutoSize = true;
            datum_potrazivanjaLabel.Location = new System.Drawing.Point(26, 84);
            datum_potrazivanjaLabel.Name = "datum_potrazivanjaLabel";
            datum_potrazivanjaLabel.Size = new System.Drawing.Size(101, 13);
            datum_potrazivanjaLabel.TabIndex = 50;
            datum_potrazivanjaLabel.Text = "Datum potraživanja:";
            // 
            // NaslovNarudzbenica
            // 
            this.NaslovNarudzbenica.AutoSize = true;
            this.NaslovNarudzbenica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovNarudzbenica.Location = new System.Drawing.Point(12, 9);
            this.NaslovNarudzbenica.Name = "NaslovNarudzbenica";
            this.NaslovNarudzbenica.Size = new System.Drawing.Size(158, 26);
            this.NaslovNarudzbenica.TabIndex = 33;
            this.NaslovNarudzbenica.Text = "Narudžbenica";
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(210, 219);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(129, 219);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // UpozorenjeArtikl
            // 
            this.UpozorenjeArtikl.AutoSize = true;
            this.UpozorenjeArtikl.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeArtikl.Location = new System.Drawing.Point(287, 132);
            this.UpozorenjeArtikl.Name = "UpozorenjeArtikl";
            this.UpozorenjeArtikl.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeArtikl.TabIndex = 66;
            this.UpozorenjeArtikl.Text = "label1";
            this.UpozorenjeArtikl.Visible = false;
            // 
            // UpozorenjeVozi
            // 
            this.UpozorenjeVozi.AutoSize = true;
            this.UpozorenjeVozi.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozi.Location = new System.Drawing.Point(287, 159);
            this.UpozorenjeVozi.Name = "UpozorenjeVozi";
            this.UpozorenjeVozi.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeVozi.TabIndex = 65;
            this.UpozorenjeVozi.Text = "label1";
            this.UpozorenjeVozi.Visible = false;
            // 
            // UpozorenjeKolicina
            // 
            this.UpozorenjeKolicina.AutoSize = true;
            this.UpozorenjeKolicina.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeKolicina.Location = new System.Drawing.Point(287, 186);
            this.UpozorenjeKolicina.Name = "UpozorenjeKolicina";
            this.UpozorenjeKolicina.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeKolicina.TabIndex = 64;
            this.UpozorenjeKolicina.Text = "label1";
            this.UpozorenjeKolicina.Visible = false;
            // 
            // UpozorenjeDatumi
            // 
            this.UpozorenjeDatumi.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumi.Location = new System.Drawing.Point(287, 54);
            this.UpozorenjeDatumi.Name = "UpozorenjeDatumi";
            this.UpozorenjeDatumi.Size = new System.Drawing.Size(103, 46);
            this.UpozorenjeDatumi.TabIndex = 63;
            this.UpozorenjeDatumi.Text = "Datum izdavanja mora biti manji od datuma potraživanja";
            this.UpozorenjeDatumi.Visible = false;
            // 
            // artiklComboBox
            // 
            this.artiklComboBox.FormattingEnabled = true;
            this.artiklComboBox.Location = new System.Drawing.Point(131, 132);
            this.artiklComboBox.Name = "artiklComboBox";
            this.artiklComboBox.Size = new System.Drawing.Size(150, 21);
            this.artiklComboBox.TabIndex = 62;
            this.artiklComboBox.SelectedIndexChanged += new System.EventHandler(this.artiklComboBox_SelectedIndexChanged);
            // 
            // voziComboBox
            // 
            this.voziComboBox.FormattingEnabled = true;
            this.voziComboBox.Location = new System.Drawing.Point(131, 159);
            this.voziComboBox.Name = "voziComboBox";
            this.voziComboBox.Size = new System.Drawing.Size(150, 21);
            this.voziComboBox.TabIndex = 61;
            this.voziComboBox.SelectedIndexChanged += new System.EventHandler(this.voziComboBox_SelectedIndexChanged);
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.Location = new System.Drawing.Point(131, 186);
            this.kolicinaTextBox.MaxLength = 6;
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(150, 20);
            this.kolicinaTextBox.TabIndex = 58;
            this.kolicinaTextBox.Leave += new System.EventHandler(this.kolicinaTextBox_Leave);
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(131, 54);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 57;
            this.datum_izdavanjaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_izdavanjaDateTimePicker_ValueChanged);
            // 
            // UpozorenjeIzdavatelj
            // 
            this.UpozorenjeIzdavatelj.AutoSize = true;
            this.UpozorenjeIzdavatelj.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeIzdavatelj.Location = new System.Drawing.Point(287, 106);
            this.UpozorenjeIzdavatelj.Name = "UpozorenjeIzdavatelj";
            this.UpozorenjeIzdavatelj.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeIzdavatelj.TabIndex = 54;
            this.UpozorenjeIzdavatelj.Text = "label1";
            this.UpozorenjeIzdavatelj.Visible = false;
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(131, 106);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(150, 21);
            this.izdavateljComboBox.TabIndex = 53;
            this.izdavateljComboBox.SelectedIndexChanged += new System.EventHandler(this.izdavateljComboBox_SelectedIndexChanged);
            // 
            // datum_potrazivanjaDateTimePicker
            // 
            this.datum_potrazivanjaDateTimePicker.Location = new System.Drawing.Point(131, 80);
            this.datum_potrazivanjaDateTimePicker.Name = "datum_potrazivanjaDateTimePicker";
            this.datum_potrazivanjaDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.datum_potrazivanjaDateTimePicker.TabIndex = 51;
            this.datum_potrazivanjaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_potrazivanjaDateTimePicker_ValueChanged);
            // 
            // frmNarudzbenicaBitumenskeMjesavineUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.NaslovNarudzbenica);
            this.Controls.Add(this.UpozorenjeArtikl);
            this.Controls.Add(this.UpozorenjeVozi);
            this.Controls.Add(this.UpozorenjeKolicina);
            this.Controls.Add(this.UpozorenjeDatumi);
            this.Controls.Add(artiklLabel);
            this.Controls.Add(this.artiklComboBox);
            this.Controls.Add(voziLabel);
            this.Controls.Add(this.voziComboBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.UpozorenjeIzdavatelj);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(datum_potrazivanjaLabel);
            this.Controls.Add(this.datum_potrazivanjaDateTimePicker);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmNarudzbenicaBitumenskeMjesavineUpdate";
            this.Text = "frmNarudzbenicaUpdate";
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.datum_potrazivanjaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_potrazivanjaLabel, 0);
            this.Controls.SetChildIndex(this.izdavateljComboBox, 0);
            this.Controls.SetChildIndex(izdavateljLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeIzdavatelj, 0);
            this.Controls.SetChildIndex(this.datum_izdavanjaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_izdavanjaLabel, 0);
            this.Controls.SetChildIndex(this.kolicinaTextBox, 0);
            this.Controls.SetChildIndex(kolicinaLabel, 0);
            this.Controls.SetChildIndex(this.voziComboBox, 0);
            this.Controls.SetChildIndex(voziLabel, 0);
            this.Controls.SetChildIndex(this.artiklComboBox, 0);
            this.Controls.SetChildIndex(artiklLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeDatumi, 0);
            this.Controls.SetChildIndex(this.UpozorenjeKolicina, 0);
            this.Controls.SetChildIndex(this.UpozorenjeVozi, 0);
            this.Controls.SetChildIndex(this.UpozorenjeArtikl, 0);
            this.Controls.SetChildIndex(this.NaslovNarudzbenica, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NaslovNarudzbenica;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label UpozorenjeArtikl;
        private System.Windows.Forms.Label UpozorenjeVozi;
        private System.Windows.Forms.Label UpozorenjeKolicina;
        private System.Windows.Forms.Label UpozorenjeDatumi;
        private System.Windows.Forms.ComboBox artiklComboBox;
        private System.Windows.Forms.ComboBox voziComboBox;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.Label UpozorenjeIzdavatelj;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.DateTimePicker datum_potrazivanjaDateTimePicker;
    }
}