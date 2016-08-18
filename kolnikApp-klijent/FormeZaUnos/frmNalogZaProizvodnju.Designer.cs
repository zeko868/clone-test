namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmNalogZaProizvodnju
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
            System.Windows.Forms.Label izdavateljLabel;
            System.Windows.Forms.Label gradilisteLabel;
            this.NaslovNalogZaProizvodnju = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.nalog_za_proizvodnjuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nalog_za_proizvodnjuTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.nalog_za_proizvodnjuTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.temeljnicaTextBox = new System.Windows.Forms.TextBox();
            this.izdavateljComboBox = new System.Windows.Forms.ComboBox();
            this.gradilisteComboBox = new System.Windows.Forms.ComboBox();
            temeljnicaLabel = new System.Windows.Forms.Label();
            izdavateljLabel = new System.Windows.Forms.Label();
            gradilisteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalog_za_proizvodnjuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(57, 13);
            temeljnicaLabel.TabIndex = 13;
            temeljnicaLabel.Text = "temeljnica:";
            // 
            // izdavateljLabel
            // 
            izdavateljLabel.AutoSize = true;
            izdavateljLabel.Location = new System.Drawing.Point(69, 106);
            izdavateljLabel.Name = "izdavateljLabel";
            izdavateljLabel.Size = new System.Drawing.Size(54, 13);
            izdavateljLabel.TabIndex = 15;
            izdavateljLabel.Text = "izdavatelj:";
            // 
            // gradilisteLabel
            // 
            gradilisteLabel.AutoSize = true;
            gradilisteLabel.Location = new System.Drawing.Point(72, 80);
            gradilisteLabel.Name = "gradilisteLabel";
            gradilisteLabel.Size = new System.Drawing.Size(51, 13);
            gradilisteLabel.TabIndex = 16;
            gradilisteLabel.Text = "gradiliste:";
            // 
            // NaslovNalogZaProizvodnju
            // 
            this.NaslovNalogZaProizvodnju.AutoSize = true;
            this.NaslovNalogZaProizvodnju.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovNalogZaProizvodnju.Location = new System.Drawing.Point(12, 9);
            this.NaslovNalogZaProizvodnju.Name = "NaslovNalogZaProizvodnju";
            this.NaslovNalogZaProizvodnju.Size = new System.Drawing.Size(235, 26);
            this.NaslovNalogZaProizvodnju.TabIndex = 7;
            this.NaslovNalogZaProizvodnju.Text = "Nalog za proizvodnju";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
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
            // nalog_za_proizvodnjuBindingSource
            // 
            this.nalog_za_proizvodnjuBindingSource.DataMember = "nalog_za_proizvodnju";
            this.nalog_za_proizvodnjuBindingSource.DataSource = this.privremeniDS;
            // 
            // nalog_za_proizvodnjuTableAdapter
            // 
            this.nalog_za_proizvodnjuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = null;
            this.tableAdapterManager.korisnicki_racunTableAdapter = null;
            this.tableAdapterManager.nalog_za_proizvodnjuTableAdapter = this.nalog_za_proizvodnjuTableAdapter;
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
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // temeljnicaTextBox
            // 
            this.temeljnicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nalog_za_proizvodnjuBindingSource, "temeljnica", true));
            this.temeljnicaTextBox.Location = new System.Drawing.Point(129, 51);
            this.temeljnicaTextBox.Name = "temeljnicaTextBox";
            this.temeljnicaTextBox.Size = new System.Drawing.Size(121, 20);
            this.temeljnicaTextBox.TabIndex = 14;
            // 
            // izdavateljComboBox
            // 
            this.izdavateljComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nalog_za_proizvodnjuBindingSource, "izdavatelj", true));
            this.izdavateljComboBox.FormattingEnabled = true;
            this.izdavateljComboBox.Location = new System.Drawing.Point(129, 103);
            this.izdavateljComboBox.Name = "izdavateljComboBox";
            this.izdavateljComboBox.Size = new System.Drawing.Size(121, 21);
            this.izdavateljComboBox.TabIndex = 16;
            // 
            // gradilisteComboBox
            // 
            this.gradilisteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nalog_za_proizvodnjuBindingSource, "gradiliste", true));
            this.gradilisteComboBox.FormattingEnabled = true;
            this.gradilisteComboBox.Location = new System.Drawing.Point(129, 77);
            this.gradilisteComboBox.Name = "gradilisteComboBox";
            this.gradilisteComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradilisteComboBox.TabIndex = 17;
            // 
            // frmNalogZaProizvodnju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(gradilisteLabel);
            this.Controls.Add(this.gradilisteComboBox);
            this.Controls.Add(izdavateljLabel);
            this.Controls.Add(this.izdavateljComboBox);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.temeljnicaTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovNalogZaProizvodnju);
            this.Name = "frmNalogZaProizvodnju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNalogZaProizvodnju";
            this.Load += new System.EventHandler(this.frmNalogZaProizvodnju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalog_za_proizvodnjuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovNalogZaProizvodnju;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource nalog_za_proizvodnjuBindingSource;
        private privremeniDSTableAdapters.nalog_za_proizvodnjuTableAdapter nalog_za_proizvodnjuTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox temeljnicaTextBox;
        private System.Windows.Forms.ComboBox izdavateljComboBox;
        private System.Windows.Forms.ComboBox gradilisteComboBox;
    }
}