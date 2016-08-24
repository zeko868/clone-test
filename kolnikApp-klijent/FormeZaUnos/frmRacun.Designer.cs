namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRacun
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
            System.Windows.Forms.Label datum_izdavanjaLabel;
            System.Windows.Forms.Label izdavateljLabel;
            this.NaslovRacun = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.racunTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NaslovRacun
            // 
            this.NaslovRacun.AutoSize = true;
            this.NaslovRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRacun.Location = new System.Drawing.Point(12, 9);
            this.NaslovRacun.Name = "NaslovRacun";
            this.NaslovRacun.Size = new System.Drawing.Size(80, 26);
            this.NaslovRacun.TabIndex = 7;
            this.NaslovRacun.Text = "Račun";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 121);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 12;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 121);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 121);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 10;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "racun";
            this.racunBindingSource.DataSource = this.privremeniDS;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.racunTableAdapter = this.racunTableAdapter;
            this.tableAdapterManager.radiTableAdapter = null;
            this.tableAdapterManager.radno_mjestoTableAdapter = null;
            this.tableAdapterManager.tablicna_privilegijaTableAdapter = null;
            this.tableAdapterManager.temeljnicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voziloTableAdapter = null;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(36, 54);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(87, 13);
            datum_izdavanjaLabel.TabIndex = 13;
            datum_izdavanjaLabel.Text = "datum izdavanja:";
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.racunBindingSource, "datum_izdavanja", true));
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 14;
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(69, 80);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(54, 13);
            izdavateljLabel.TabIndex = 14;
            izdavateljLabel.Text = "izdavatelj:";
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racunBindingSource, "izdavatelj", true));
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(129, 77);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(131, 21);
            this.izdavateljComboBox.TabIndex = 15;
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRacun);
            this.Name = "frmRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRacun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRacun;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private privremeniDSTableAdapters.racunTableAdapter racunTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
    }
}