namespace kolnikApp_klijent.FormeZaUpdate
{
    partial class frmVoziUpdate
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
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label vozacLabel;
            System.Windows.Forms.Label voziloLabel;
            this.UpozorenjeDatumi = new System.Windows.Forms.Label();
            this.UpozorenjeVozac = new System.Windows.Forms.Label();
            this.UpozorenjeVozilo = new System.Windows.Forms.Label();
            this.vozacComboBox = new System.Windows.Forms.ComboBox();
            this.voziloComboBox = new System.Windows.Forms.ComboBox();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovVozi = new System.Windows.Forms.Label();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            vozacLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
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
            this.Minimize.Location = new System.Drawing.Point(698, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Minimize.Size = new System.Drawing.Size(44, 38);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(753, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RestoreDown.Size = new System.Drawing.Size(44, 38);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(809, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CloseButton.Size = new System.Drawing.Size(44, 38);
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(47, 166);
            datum_zavrsetkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(118, 17);
            datum_zavrsetkaLabel.TabIndex = 42;
            datum_zavrsetkaLabel.Text = "Datum završetka:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(56, 134);
            datum_pocetkaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(107, 17);
            datum_pocetkaLabel.TabIndex = 40;
            datum_pocetkaLabel.Text = "Datum početka:";
            // 
            // vozacLabel
            // 
            vozacLabel.AutoSize = true;
            vozacLabel.Location = new System.Drawing.Point(112, 100);
            vozacLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vozacLabel.Name = "vozacLabel";
            vozacLabel.Size = new System.Drawing.Size(51, 17);
            vozacLabel.TabIndex = 38;
            vozacLabel.Text = "Vozač:";
            // 
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(115, 66);
            voziloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(50, 17);
            voziloLabel.TabIndex = 37;
            voziloLabel.Text = "Vozilo:";
            // 
            // UpozorenjeDatumi
            // 
            this.UpozorenjeDatumi.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeDatumi.Location = new System.Drawing.Point(363, 129);
            this.UpozorenjeDatumi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeDatumi.Name = "UpozorenjeDatumi";
            this.UpozorenjeDatumi.Size = new System.Drawing.Size(120, 57);
            this.UpozorenjeDatumi.TabIndex = 47;
            this.UpozorenjeDatumi.Text = "Datum završetka mora biti veći od datuma početka";
            this.UpozorenjeDatumi.Visible = false;
            // 
            // UpozorenjeVozac
            // 
            this.UpozorenjeVozac.AutoSize = true;
            this.UpozorenjeVozac.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozac.Location = new System.Drawing.Point(363, 96);
            this.UpozorenjeVozac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeVozac.Name = "UpozorenjeVozac";
            this.UpozorenjeVozac.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeVozac.TabIndex = 46;
            this.UpozorenjeVozac.Text = "label1";
            this.UpozorenjeVozac.Visible = false;
            // 
            // UpozorenjeVozilo
            // 
            this.UpozorenjeVozilo.AutoSize = true;
            this.UpozorenjeVozilo.BackColor = System.Drawing.Color.Khaki;
            this.UpozorenjeVozilo.Location = new System.Drawing.Point(363, 63);
            this.UpozorenjeVozilo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpozorenjeVozilo.Name = "UpozorenjeVozilo";
            this.UpozorenjeVozilo.Size = new System.Drawing.Size(46, 17);
            this.UpozorenjeVozilo.TabIndex = 45;
            this.UpozorenjeVozilo.Text = "label1";
            this.UpozorenjeVozilo.Visible = false;
            // 
            // vozacComboBox
            // 
            this.vozacComboBox.FormattingEnabled = true;
            this.vozacComboBox.Location = new System.Drawing.Point(172, 96);
            this.vozacComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vozacComboBox.Name = "vozacComboBox";
            this.vozacComboBox.Size = new System.Drawing.Size(181, 24);
            this.vozacComboBox.TabIndex = 41;
            this.vozacComboBox.SelectedIndexChanged += new System.EventHandler(this.vozacComboBox_SelectedIndexChanged);
            // 
            // voziloComboBox
            // 
            this.voziloComboBox.FormattingEnabled = true;
            this.voziloComboBox.Location = new System.Drawing.Point(172, 63);
            this.voziloComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.voziloComboBox.Name = "voziloComboBox";
            this.voziloComboBox.Size = new System.Drawing.Size(181, 24);
            this.voziloComboBox.TabIndex = 39;
            this.voziloComboBox.SelectedIndexChanged += new System.EventHandler(this.voziloComboBox_SelectedIndexChanged);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(280, 207);
            this.GumbIzlaz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(100, 28);
            this.GumbIzlaz.TabIndex = 35;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(172, 207);
            this.GumbPotvrda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(100, 28);
            this.GumbPotvrda.TabIndex = 34;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            this.GumbPotvrda.Click += new System.EventHandler(this.GumbPotvrda_Click);
            // 
            // NaslovVozi
            // 
            this.NaslovVozi.AutoSize = true;
            this.NaslovVozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovVozi.Location = new System.Drawing.Point(16, 11);
            this.NaslovVozi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovVozi.Name = "NaslovVozi";
            this.NaslovVozi.Size = new System.Drawing.Size(298, 31);
            this.NaslovVozi.TabIndex = 33;
            this.NaslovVozi.Text = "Dodjela vozila vozaču";
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(172, 129);
            this.datum_pocetkaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(181, 22);
            this.datum_pocetkaDateTimePicker.TabIndex = 48;
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(172, 161);
            this.datum_zavrsetkaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.ShowCheckBox = true;
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(181, 22);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 49;
            // 
            // frmVoziUpdate
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.ControlBox = false;
            this.Controls.Add(this.datum_zavrsetkaDateTimePicker);
            this.Controls.Add(this.datum_pocetkaDateTimePicker);
            this.Controls.Add(this.UpozorenjeDatumi);
            this.Controls.Add(this.UpozorenjeVozac);
            this.Controls.Add(this.UpozorenjeVozilo);
            this.Controls.Add(datum_zavrsetkaLabel);
            this.Controls.Add(datum_pocetkaLabel);
            this.Controls.Add(vozacLabel);
            this.Controls.Add(this.vozacComboBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloComboBox);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovVozi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1707, 1211);
            this.Name = "frmVoziUpdate";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "frmVoziUpdate";
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.Controls.SetChildIndex(this.NaslovVozi, 0);
            this.Controls.SetChildIndex(this.GumbPotvrda, 0);
            this.Controls.SetChildIndex(this.GumbIzlaz, 0);
            this.Controls.SetChildIndex(this.voziloComboBox, 0);
            this.Controls.SetChildIndex(voziloLabel, 0);
            this.Controls.SetChildIndex(this.vozacComboBox, 0);
            this.Controls.SetChildIndex(vozacLabel, 0);
            this.Controls.SetChildIndex(datum_pocetkaLabel, 0);
            this.Controls.SetChildIndex(datum_zavrsetkaLabel, 0);
            this.Controls.SetChildIndex(this.UpozorenjeVozilo, 0);
            this.Controls.SetChildIndex(this.UpozorenjeVozac, 0);
            this.Controls.SetChildIndex(this.UpozorenjeDatumi, 0);
            this.Controls.SetChildIndex(this.datum_pocetkaDateTimePicker, 0);
            this.Controls.SetChildIndex(this.datum_zavrsetkaDateTimePicker, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpozorenjeDatumi;
        private System.Windows.Forms.Label UpozorenjeVozac;
        private System.Windows.Forms.Label UpozorenjeVozilo;
        private System.Windows.Forms.ComboBox vozacComboBox;
        private System.Windows.Forms.ComboBox voziloComboBox;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovVozi;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
    }
}