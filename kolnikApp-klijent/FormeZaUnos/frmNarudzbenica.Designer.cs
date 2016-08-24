namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmNarudzbenica
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
            System.Windows.Forms.Label temeljnicaLabel;
            System.Windows.Forms.Label datum_potrazivanjaLabel;
            System.Windows.Forms.Label naruciteljLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.narudzbenica_bitumenske_mjesavineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenica_bitumenske_mjesavineTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.narudzbenica_bitumenske_mjesavineTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.temeljnicaTextBox = new System.Windows.Forms.TextBox();
            this.datum_potrazivanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.naruciteljComboBox = new System.Windows.Forms.ComboBox();
            this.NaslovNarudzbenica = new System.Windows.Forms.Label();
            temeljnicaLabel = new System.Windows.Forms.Label();
            datum_potrazivanjaLabel = new System.Windows.Forms.Label();
            naruciteljLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenica_bitumenske_mjesavineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(57, 13);
            temeljnicaLabel.TabIndex = 16;
            temeljnicaLabel.Text = "temeljnica:";
            // 
            // datum_potrazivanjaLabel
            // 
            datum_potrazivanjaLabel.AutoSize = true;
            datum_potrazivanjaLabel.Location = new System.Drawing.Point(24, 81);
            datum_potrazivanjaLabel.Name = "datum_potrazivanjaLabel";
            datum_potrazivanjaLabel.Size = new System.Drawing.Size(99, 13);
            datum_potrazivanjaLabel.TabIndex = 17;
            datum_potrazivanjaLabel.Text = "datum potrazivanja:";
            // 
            // naruciteljLabel
            // 
            naruciteljLabel.AutoSize = true;
            naruciteljLabel.Location = new System.Drawing.Point(71, 106);
            naruciteljLabel.Name = "naruciteljLabel";
            naruciteljLabel.Size = new System.Drawing.Size(52, 13);
            naruciteljLabel.TabIndex = 18;
            naruciteljLabel.Text = "narucitelj:";
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
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudzbenica_bitumenske_mjesavineBindingSource
            // 
            this.narudzbenica_bitumenske_mjesavineBindingSource.DataMember = "narudzbenica_bitumenske_mjesavine";
            this.narudzbenica_bitumenske_mjesavineBindingSource.DataSource = this.privremeniDS;
            // 
            // narudzbenica_bitumenske_mjesavineTableAdapter
            // 
            this.narudzbenica_bitumenske_mjesavineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = null;
            this.tableAdapterManager.korisnicki_racunTableAdapter = null;
            this.tableAdapterManager.nalog_za_proizvodnjuTableAdapter = null;
            this.tableAdapterManager.narudzbenica_bitumenske_mjesavineTableAdapter = this.narudzbenica_bitumenske_mjesavineTableAdapter;
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
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // temeljnicaTextBox
            // 
            this.temeljnicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbenica_bitumenske_mjesavineBindingSource, "temeljnica", true));
            this.temeljnicaTextBox.Location = new System.Drawing.Point(129, 51);
            this.temeljnicaTextBox.Name = "temeljnicaTextBox";
            this.temeljnicaTextBox.Size = new System.Drawing.Size(138, 20);
            this.temeljnicaTextBox.TabIndex = 17;
            // 
            // datum_potrazivanjaDateTimePicker
            // 
            this.datum_potrazivanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.narudzbenica_bitumenske_mjesavineBindingSource, "datum_potrazivanja", true));
            this.datum_potrazivanjaDateTimePicker.Location = new System.Drawing.Point(129, 77);
            this.datum_potrazivanjaDateTimePicker.Name = "datum_potrazivanjaDateTimePicker";
            this.datum_potrazivanjaDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.datum_potrazivanjaDateTimePicker.TabIndex = 18;
            // 
            // naruciteljComboBox
            // 
            this.naruciteljComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbenica_bitumenske_mjesavineBindingSource, "narucitelj", true));
            this.naruciteljComboBox.FormattingEnabled = true;
            this.naruciteljComboBox.Location = new System.Drawing.Point(129, 103);
            this.naruciteljComboBox.Name = "naruciteljComboBox";
            this.naruciteljComboBox.Size = new System.Drawing.Size(138, 21);
            this.naruciteljComboBox.TabIndex = 19;
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
            // frmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(this.NaslovNarudzbenica);
            this.Controls.Add(naruciteljLabel);
            this.Controls.Add(this.naruciteljComboBox);
            this.Controls.Add(datum_potrazivanjaLabel);
            this.Controls.Add(this.datum_potrazivanjaDateTimePicker);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.temeljnicaTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Name = "frmNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNarudzbenica";
            this.Load += new System.EventHandler(this.frmNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenica_bitumenske_mjesavineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource narudzbenica_bitumenske_mjesavineBindingSource;
        private privremeniDSTableAdapters.narudzbenica_bitumenske_mjesavineTableAdapter narudzbenica_bitumenske_mjesavineTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox temeljnicaTextBox;
        private System.Windows.Forms.DateTimePicker datum_potrazivanjaDateTimePicker;
        private System.Windows.Forms.ComboBox naruciteljComboBox;
        private System.Windows.Forms.Label NaslovNarudzbenica;
    }
}