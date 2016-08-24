namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmTemeljnica
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
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label voziloLabel;
            System.Windows.Forms.Label vozacLabel;
            System.Windows.Forms.Label artiklLabel;
            this.NaslovTemeljnica = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.temeljnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temeljnicaTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.temeljnicaTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.datum_izdavanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.voziloComboBox = new System.Windows.Forms.ComboBox();
            this.vozacComboBox = new System.Windows.Forms.ComboBox();
            this.artiklComboBox = new System.Windows.Forms.ComboBox();
            datum_izdavanjaLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            vozacLabel = new System.Windows.Forms.Label();
            artiklLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temeljnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datum_izdavanjaLabel
            // 
            datum_izdavanjaLabel.AutoSize = true;
            datum_izdavanjaLabel.Location = new System.Drawing.Point(36, 55);
            datum_izdavanjaLabel.Name = "datum_izdavanjaLabel";
            datum_izdavanjaLabel.Size = new System.Drawing.Size(87, 13);
            datum_izdavanjaLabel.TabIndex = 22;
            datum_izdavanjaLabel.Text = "datum izdavanja:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(77, 80);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(46, 13);
            kolicinaLabel.TabIndex = 23;
            kolicinaLabel.Text = "kolicina:";
            // 
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(86, 106);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(37, 13);
            voziloLabel.TabIndex = 24;
            voziloLabel.Text = "vozilo:";
            // 
            // vozacLabel
            // 
            vozacLabel.AutoSize = true;
            vozacLabel.Location = new System.Drawing.Point(84, 133);
            vozacLabel.Name = "vozacLabel";
            vozacLabel.Size = new System.Drawing.Size(39, 13);
            vozacLabel.TabIndex = 25;
            vozacLabel.Text = "vozac:";
            // 
            // artiklLabel
            // 
            artiklLabel.AutoSize = true;
            artiklLabel.Location = new System.Drawing.Point(91, 160);
            artiklLabel.Name = "artiklLabel";
            artiklLabel.Size = new System.Drawing.Size(32, 13);
            artiklLabel.TabIndex = 26;
            artiklLabel.Text = "artikl:";
            // 
            // NaslovTemeljnica
            // 
            this.NaslovTemeljnica.AutoSize = true;
            this.NaslovTemeljnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTemeljnica.Location = new System.Drawing.Point(12, 9);
            this.NaslovTemeljnica.Name = "NaslovTemeljnica";
            this.NaslovTemeljnica.Size = new System.Drawing.Size(127, 26);
            this.NaslovTemeljnica.TabIndex = 10;
            this.NaslovTemeljnica.Text = "Temeljnica";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 192);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 21;
            this.GumbReset.Text = "Reset";
            this.GumbReset.UseVisualStyleBackColor = true;
            this.GumbReset.Click += new System.EventHandler(this.GumbReset_Click);
            // 
            // GumbIzlaz
            // 
            this.GumbIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 192);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 20;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 192);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 19;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temeljnicaBindingSource
            // 
            this.temeljnicaBindingSource.DataMember = "temeljnica";
            this.temeljnicaBindingSource.DataSource = this.privremeniDS;
            // 
            // temeljnicaTableAdapter
            // 
            this.temeljnicaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.temeljnicaTableAdapter = this.temeljnicaTableAdapter;
            this.tableAdapterManager.UpdateOrder = kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voziloTableAdapter = null;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // datum_izdavanjaDateTimePicker
            // 
            this.datum_izdavanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.temeljnicaBindingSource, "datum_izdavanja", true));
            this.datum_izdavanjaDateTimePicker.Location = new System.Drawing.Point(129, 51);
            this.datum_izdavanjaDateTimePicker.Name = "datum_izdavanjaDateTimePicker";
            this.datum_izdavanjaDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.datum_izdavanjaDateTimePicker.TabIndex = 23;
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temeljnicaBindingSource, "kolicina", true));
            this.kolicinaTextBox.Location = new System.Drawing.Point(129, 77);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(131, 20);
            this.kolicinaTextBox.TabIndex = 24;
            // 
            // voziloComboBox
            // 
            this.voziloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temeljnicaBindingSource, "vozilo", true));
            this.voziloComboBox.FormattingEnabled = true;
            this.voziloComboBox.Location = new System.Drawing.Point(129, 103);
            this.voziloComboBox.Name = "voziloComboBox";
            this.voziloComboBox.Size = new System.Drawing.Size(131, 21);
            this.voziloComboBox.TabIndex = 25;
            // 
            // vozacComboBox
            // 
            this.vozacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temeljnicaBindingSource, "vozac", true));
            this.vozacComboBox.FormattingEnabled = true;
            this.vozacComboBox.Location = new System.Drawing.Point(129, 130);
            this.vozacComboBox.Name = "vozacComboBox";
            this.vozacComboBox.Size = new System.Drawing.Size(131, 21);
            this.vozacComboBox.TabIndex = 26;
            // 
            // artiklComboBox
            // 
            this.artiklComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temeljnicaBindingSource, "artikl", true));
            this.artiklComboBox.FormattingEnabled = true;
            this.artiklComboBox.Location = new System.Drawing.Point(129, 157);
            this.artiklComboBox.Name = "artiklComboBox";
            this.artiklComboBox.Size = new System.Drawing.Size(131, 21);
            this.artiklComboBox.TabIndex = 27;
            // 
            // frmTemeljnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(artiklLabel);
            this.Controls.Add(this.artiklComboBox);
            this.Controls.Add(vozacLabel);
            this.Controls.Add(this.vozacComboBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloComboBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(datum_izdavanjaLabel);
            this.Controls.Add(this.datum_izdavanjaDateTimePicker);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTemeljnica);
            this.Name = "frmTemeljnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTemeljnica";
            this.Load += new System.EventHandler(this.frmTemeljnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temeljnicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovTemeljnica;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource temeljnicaBindingSource;
        private privremeniDSTableAdapters.temeljnicaTableAdapter temeljnicaTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker datum_izdavanjaDateTimePicker;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.ComboBox voziloComboBox;
        private System.Windows.Forms.ComboBox vozacComboBox;
        private System.Windows.Forms.ComboBox artiklComboBox;
    }
}