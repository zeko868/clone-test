namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRadi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label zaposlenikLabel;
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            this.NaslovRadi = new System.Windows.Forms.Label();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.radiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.radiTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.zaposlenikComboBox = new System.Windows.Forms.ComboBox();
            this.radno_mjestoComboBox = new System.Windows.Forms.ComboBox();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbReset = new System.Windows.Forms.Button();
            zaposlenikLabel = new System.Windows.Forms.Label();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(63, 54);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(60, 13);
            zaposlenikLabel.TabIndex = 16;
            zaposlenikLabel.Text = "zaposlenik:";
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(53, 81);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(70, 13);
            radno_mjestoLabel.TabIndex = 17;
            radno_mjestoLabel.Text = "radno mjesto:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(42, 109);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(81, 13);
            datum_pocetkaLabel.TabIndex = 18;
            datum_pocetkaLabel.Text = "datum pocetka:";
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(35, 135);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(88, 13);
            datum_zavrsetkaLabel.TabIndex = 19;
            datum_zavrsetkaLabel.Text = "datum zavrsetka:";
            // 
            // NaslovRadi
            // 
            this.NaslovRadi.AutoSize = true;
            this.NaslovRadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRadi.Location = new System.Drawing.Point(12, 9);
            this.NaslovRadi.Name = "NaslovRadi";
            this.NaslovRadi.Size = new System.Drawing.Size(292, 26);
            this.NaslovRadi.TabIndex = 8;
            this.NaslovRadi.Text = "Radno mjesto zaposlenika";
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radiBindingSource
            // 
            this.radiBindingSource.DataMember = "radi";
            this.radiBindingSource.DataSource = this.privremeniDS;
            // 
            // radiTableAdapter
            // 
            this.radiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = null;
            this.tableAdapterManager.korisnicki_racunTableAdapter = null;
            this.tableAdapterManager.nalog_za_proizvodnjuTableAdapter = null;
            this.tableAdapterManager.narudzbenica_bitumenske_mjesavineTableAdapter = null;
            this.tableAdapterManager.otpremnicaTableAdapter = null;
            this.tableAdapterManager.poduzeceTableAdapter = null;
            this.tableAdapterManager.rabatTableAdapter = null;
            this.tableAdapterManager.racunTableAdapter = null;
            this.tableAdapterManager.radiTableAdapter = this.radiTableAdapter;
            this.tableAdapterManager.radno_mjestoTableAdapter = null;
            this.tableAdapterManager.tablicna_privilegijaTableAdapter = null;
            this.tableAdapterManager.temeljnicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voziloTableAdapter = null;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // zaposlenikComboBox
            // 
            this.zaposlenikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radiBindingSource, "zaposlenik", true));
            this.zaposlenikComboBox.FormattingEnabled = true;
            this.zaposlenikComboBox.Location = new System.Drawing.Point(129, 51);
            this.zaposlenikComboBox.Name = "zaposlenikComboBox";
            this.zaposlenikComboBox.Size = new System.Drawing.Size(133, 21);
            this.zaposlenikComboBox.TabIndex = 17;
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.radiBindingSource, "radno_mjesto", true));
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(129, 78);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(133, 21);
            this.radno_mjestoComboBox.TabIndex = 18;
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radiBindingSource, "datum_pocetka", true));
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(129, 105);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.datum_pocetkaDateTimePicker.TabIndex = 19;
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.radiBindingSource, "datum_zavrsetka", true));
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(129, 131);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 20;
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 13;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 169);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 14;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 15;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // frmRadi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(datum_zavrsetkaLabel);
            this.Controls.Add(this.datum_zavrsetkaDateTimePicker);
            this.Controls.Add(datum_pocetkaLabel);
            this.Controls.Add(this.datum_pocetkaDateTimePicker);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.radno_mjestoComboBox);
            this.Controls.Add(zaposlenikLabel);
            this.Controls.Add(this.zaposlenikComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRadi);
            this.Name = "frmRadi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRadi";
            this.Load += new System.EventHandler(this.frmRadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRadi;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource radiBindingSource;
        private privremeniDSTableAdapters.radiTableAdapter radiTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox zaposlenikComboBox;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbReset;
    }
}