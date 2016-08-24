namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmZaposen
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
            System.Windows.Forms.Label poduzeceLabel;
            System.Windows.Forms.Label datum_pocetkaLabel;
            System.Windows.Forms.Label datum_zavrsetkaLabel;
            this.NaslovZaposlen = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.zaposlenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.zaposlenTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.zaposlenikComboBox = new System.Windows.Forms.ComboBox();
            this.poduzeceComboBox = new System.Windows.Forms.ComboBox();
            this.datum_pocetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datum_zavrsetkaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            zaposlenikLabel = new System.Windows.Forms.Label();
            poduzeceLabel = new System.Windows.Forms.Label();
            datum_pocetkaLabel = new System.Windows.Forms.Label();
            datum_zavrsetkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(63, 54);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(60, 13);
            zaposlenikLabel.TabIndex = 28;
            zaposlenikLabel.Text = "zaposlenik:";
            // 
            // poduzeceLabel
            // 
            poduzeceLabel.AutoSize = true;
            poduzeceLabel.Location = new System.Drawing.Point(66, 81);
            poduzeceLabel.Name = "poduzeceLabel";
            poduzeceLabel.Size = new System.Drawing.Size(57, 13);
            poduzeceLabel.TabIndex = 29;
            poduzeceLabel.Text = "poduzece:";
            // 
            // datum_pocetkaLabel
            // 
            datum_pocetkaLabel.AutoSize = true;
            datum_pocetkaLabel.Location = new System.Drawing.Point(42, 109);
            datum_pocetkaLabel.Name = "datum_pocetkaLabel";
            datum_pocetkaLabel.Size = new System.Drawing.Size(81, 13);
            datum_pocetkaLabel.TabIndex = 30;
            datum_pocetkaLabel.Text = "datum pocetka:";
            // 
            // datum_zavrsetkaLabel
            // 
            datum_zavrsetkaLabel.AutoSize = true;
            datum_zavrsetkaLabel.Location = new System.Drawing.Point(35, 135);
            datum_zavrsetkaLabel.Name = "datum_zavrsetkaLabel";
            datum_zavrsetkaLabel.Size = new System.Drawing.Size(88, 13);
            datum_zavrsetkaLabel.TabIndex = 31;
            datum_zavrsetkaLabel.Text = "datum zavrsetka:";
            // 
            // NaslovZaposlen
            // 
            this.NaslovZaposlen.AutoSize = true;
            this.NaslovZaposlen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlen.Location = new System.Drawing.Point(12, 9);
            this.NaslovZaposlen.Name = "NaslovZaposlen";
            this.NaslovZaposlen.Size = new System.Drawing.Size(213, 26);
            this.NaslovZaposlen.TabIndex = 13;
            this.NaslovZaposlen.Text = "Radnik - Poduzeće";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 27;
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
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 25;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenBindingSource
            // 
            this.zaposlenBindingSource.DataMember = "zaposlen";
            this.zaposlenBindingSource.DataSource = this.privremeniDS;
            // 
            // zaposlenTableAdapter
            // 
            this.zaposlenTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.radiTableAdapter = null;
            this.tableAdapterManager.radno_mjestoTableAdapter = null;
            this.tableAdapterManager.tablicna_privilegijaTableAdapter = null;
            this.tableAdapterManager.temeljnicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voziloTableAdapter = null;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = this.zaposlenTableAdapter;
            // 
            // zaposlenikComboBox
            // 
            this.zaposlenikComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenBindingSource, "zaposlenik", true));
            this.zaposlenikComboBox.FormattingEnabled = true;
            this.zaposlenikComboBox.Location = new System.Drawing.Point(129, 51);
            this.zaposlenikComboBox.Name = "zaposlenikComboBox";
            this.zaposlenikComboBox.Size = new System.Drawing.Size(134, 21);
            this.zaposlenikComboBox.TabIndex = 29;
            // 
            // poduzeceComboBox
            // 
            this.poduzeceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenBindingSource, "poduzece", true));
            this.poduzeceComboBox.FormattingEnabled = true;
            this.poduzeceComboBox.Location = new System.Drawing.Point(129, 78);
            this.poduzeceComboBox.Name = "poduzeceComboBox";
            this.poduzeceComboBox.Size = new System.Drawing.Size(134, 21);
            this.poduzeceComboBox.TabIndex = 30;
            // 
            // datum_pocetkaDateTimePicker
            // 
            this.datum_pocetkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zaposlenBindingSource, "datum_pocetka", true));
            this.datum_pocetkaDateTimePicker.Location = new System.Drawing.Point(129, 105);
            this.datum_pocetkaDateTimePicker.Name = "datum_pocetkaDateTimePicker";
            this.datum_pocetkaDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.datum_pocetkaDateTimePicker.TabIndex = 31;
            // 
            // datum_zavrsetkaDateTimePicker
            // 
            this.datum_zavrsetkaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zaposlenBindingSource, "datum_zavrsetka", true));
            this.datum_zavrsetkaDateTimePicker.Location = new System.Drawing.Point(129, 131);
            this.datum_zavrsetkaDateTimePicker.Name = "datum_zavrsetkaDateTimePicker";
            this.datum_zavrsetkaDateTimePicker.Size = new System.Drawing.Size(134, 20);
            this.datum_zavrsetkaDateTimePicker.TabIndex = 32;
            // 
            // frmZaposen
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
            this.Controls.Add(poduzeceLabel);
            this.Controls.Add(this.poduzeceComboBox);
            this.Controls.Add(zaposlenikLabel);
            this.Controls.Add(this.zaposlenikComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovZaposlen);
            this.Name = "frmZaposen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposen";
            this.Load += new System.EventHandler(this.frmZaposen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovZaposlen;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource zaposlenBindingSource;
        private privremeniDSTableAdapters.zaposlenTableAdapter zaposlenTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox zaposlenikComboBox;
        private System.Windows.Forms.ComboBox poduzeceComboBox;
        private System.Windows.Forms.DateTimePicker datum_pocetkaDateTimePicker;
        private System.Windows.Forms.DateTimePicker datum_zavrsetkaDateTimePicker;
    }
}