﻿namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmVozi
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
            System.Windows.Forms.Label voziloLabel;
            System.Windows.Forms.Label vozacLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.voziloComboBox = new System.Windows.Forms.ComboBox();
            this.vozacComboBox = new System.Windows.Forms.ComboBox();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NaslovVozi = new System.Windows.Forms.Label();
            this.UpozorenjeVozilo = new System.Windows.Forms.Label();
            this.UpozorenjeVozac = new System.Windows.Forms.Label();
            this.UpozorenjeDatumi = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            vozacLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
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
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(86, 54);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(38, 13);
            voziloLabel.TabIndex = 25;
            voziloLabel.Text = "Vozilo:";
            // 
            // vozacLabel
            // 
            vozacLabel.AutoSize = true;
            vozacLabel.Location = new System.Drawing.Point(84, 81);
            vozacLabel.Name = "vozacLabel";
            vozacLabel.Size = new System.Drawing.Size(40, 13);
            vozacLabel.TabIndex = 26;
            vozacLabel.Text = "Vozac:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(42, 109);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(83, 13);
            datum_pocetkaLabel.TabIndex = 27;
            datum_pocetkaLabel.Text = "Datum pocetka:";
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(35, 135);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(90, 13);
            datum_zavrsetkaLabel.TabIndex = 28;
            datum_zavrsetkaLabel.Text = "Datum zavrsetka:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 24;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 169);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 23;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 22;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // voziloComboBox
            // 
            this.voziloComboBox.FormattingEnabled = true;
            this.voziloComboBox.Location = new System.Drawing.Point(129, 51);
            this.voziloComboBox.Name = "voziloComboBox";
            this.voziloComboBox.Size = new System.Drawing.Size(137, 21);
            this.voziloComboBox.TabIndex = 26;
            this.voziloComboBox.SelectedIndexChanged += new System.EventHandler(this.voziloComboBox_SelectedIndexChanged);
            // 
            // vozacComboBox
            // 
            this.vozacComboBox.FormattingEnabled = true;
            this.vozacComboBox.Location = new System.Drawing.Point(129, 78);
            this.vozacComboBox.Name = "vozacComboBox";
            this.vozacComboBox.Size = new System.Drawing.Size(137, 21);
            this.vozacComboBox.TabIndex = 27;
            this.vozacComboBox.SelectedIndexChanged += new System.EventHandler(this.vozacComboBox_SelectedIndexChanged);
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(129, 105);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.datum_pocetkaDateTimePicker.TabIndex = 28;
            this.datum_pocetkaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_pocetkaDateTimePicker_ValueChanged);
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(129, 131);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.ShowCheckBox = true;
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 29;
            this.datum_zavrsetkaDateTimePicker.ValueChanged += new System.EventHandler(this.datum_zavrsetkaDateTimePicker_ValueChanged);
            // 
            // NaslovVozi
            // 
            this.NaslovVozi.AutoSize = true;
            this.NaslovVozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovVozi.Location = new System.Drawing.Point(12, 9);
            this.NaslovVozi.Name = "NaslovVozi";
            this.NaslovVozi.Size = new System.Drawing.Size(244, 26);
            this.NaslovVozi.TabIndex = 11;
            this.NaslovVozi.Text = "Dodjela vozila vozaču";
            // 
            // UpozorenjeVozilo
            // 
            this.UpozorenjeVozilo.AutoSize = true;
            this.UpozorenjeVozilo.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozilo.Location = new System.Drawing.Point(272, 51);
            this.UpozorenjeVozilo.Name = "UpozorenjeVozilo";
            this.UpozorenjeVozilo.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeVozilo.TabIndex = 30;
            this.UpozorenjeVozilo.Text = "label1";
            this.UpozorenjeVozilo.Visible = false;
            // 
            // UpozorenjeVozac
            // 
            this.UpozorenjeVozac.AutoSize = true;
            this.UpozorenjeVozac.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozac.Location = new System.Drawing.Point(272, 78);
            this.UpozorenjeVozac.Name = "UpozorenjeVozac";
            this.UpozorenjeVozac.Size = new System.Drawing.Size(35, 13);
            this.UpozorenjeVozac.TabIndex = 31;
            this.UpozorenjeVozac.Text = "label1";
            this.UpozorenjeVozac.Visible = false;
            // 
            // UpozorenjeDatumi
            // 
            this.UpozorenjeDatumi.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumi.Location = new System.Drawing.Point(272, 105);
            this.UpozorenjeDatumi.Name = "UpozorenjeDatumi";
            this.UpozorenjeDatumi.Size = new System.Drawing.Size(90, 46);
            this.UpozorenjeDatumi.TabIndex = 32;
            this.UpozorenjeDatumi.Text = "Datum završetka mora biti veći od datuma početka";
            this.UpozorenjeDatumi.Visible = false;
            // 
            // frmVozi
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.UpozorenjeDatumi);
            this.Controls.Add(this.UpozorenjeVozac);
            this.Controls.Add(this.UpozorenjeVozilo);
            this.Controls.Add(datum_zavrsetkaLabel);
            this.Controls.Add(this.datum_zavrsetkaDateTimePicker);
            this.Controls.Add(datum_pocetkaLabel);
            this.Controls.Add(this.datum_pocetkaDateTimePicker);
            this.Controls.Add(vozacLabel);
            this.Controls.Add(this.vozacComboBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovVozi);
            this.MaximumSize = new System.Drawing.Size(1280, 984);
            this.Name = "frmVozi";
            this.Text = "frmVozi";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovVozi, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.GumbReset, 0);
            this.Controls.SetChildIndex(this.voziloComboBox, 0);
            this.Controls.SetChildIndex(voziloLabel, 0);
            this.Controls.SetChildIndex(this.vozacComboBox, 0);
            this.Controls.SetChildIndex(vozacLabel, 0);
            this.Controls.SetChildIndex(this.datum_pocetkaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_pocetkaLabel, 0);
            this.Controls.SetChildIndex(this.datum_zavrsetkaDateTimePicker, 0);
            this.Controls.SetChildIndex(datum_zavrsetkaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeVozilo, 0);
            this.Controls.SetChildIndex(this.UpozorenjeVozac, 0);
            this.Controls.SetChildIndex(this.UpozorenjeDatumi, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.ComboBox voziloComboBox;
        private System.Windows.Forms.ComboBox vozacComboBox;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
        private System.Windows.Forms.Label NaslovVozi;
        private System.Windows.Forms.Label UpozorenjeVozilo;
        private System.Windows.Forms.Label UpozorenjeVozac;
        private System.Windows.Forms.Label UpozorenjeDatumi;
    }
}