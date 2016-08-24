namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmTablicaPrivilegija
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
            System.Windows.Forms.Label radno_mjestoLabel;
            System.Windows.Forms.Label naziv_tabliceLabel;
            System.Windows.Forms.Label operacijaLabel;
            this.NaslovTablicaPrivilegija = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.tablicna_privilegijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablicna_privilegijaTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.tablicna_privilegijaTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.radno_mjestoComboBox = new System.Windows.Forms.ComboBox();
            this.naziv_tabliceComboBox = new System.Windows.Forms.ComboBox();
            this.operacijaComboBox = new System.Windows.Forms.ComboBox();
            radno_mjestoLabel = new System.Windows.Forms.Label();
            naziv_tabliceLabel = new System.Windows.Forms.Label();
            operacijaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablicna_privilegijaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // radno_mjestoLabel
            // 
            radno_mjestoLabel.AutoSize = true;
            radno_mjestoLabel.Location = new System.Drawing.Point(53, 54);
            radno_mjestoLabel.Name = "radno_mjestoLabel";
            radno_mjestoLabel.Size = new System.Drawing.Size(70, 13);
            radno_mjestoLabel.TabIndex = 19;
            radno_mjestoLabel.Text = "radno mjesto:";
            // 
            // naziv_tabliceLabel
            // 
            naziv_tabliceLabel.AutoSize = true;
            naziv_tabliceLabel.Location = new System.Drawing.Point(54, 81);
            naziv_tabliceLabel.Name = "naziv_tabliceLabel";
            naziv_tabliceLabel.Size = new System.Drawing.Size(69, 13);
            naziv_tabliceLabel.TabIndex = 20;
            naziv_tabliceLabel.Text = "naziv tablice:";
            // 
            // operacijaLabel
            // 
            operacijaLabel.AutoSize = true;
            operacijaLabel.Location = new System.Drawing.Point(70, 108);
            operacijaLabel.Name = "operacijaLabel";
            operacijaLabel.Size = new System.Drawing.Size(53, 13);
            operacijaLabel.TabIndex = 21;
            operacijaLabel.Text = "operacija:";
            // 
            // NaslovTablicaPrivilegija
            // 
            this.NaslovTablicaPrivilegija.AutoSize = true;
            this.NaslovTablicaPrivilegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablicaPrivilegija.Location = new System.Drawing.Point(12, 9);
            this.NaslovTablicaPrivilegija.Name = "NaslovTablicaPrivilegija";
            this.NaslovTablicaPrivilegija.Size = new System.Drawing.Size(275, 26);
            this.NaslovTablicaPrivilegija.TabIndex = 9;
            this.NaslovTablicaPrivilegija.Text = "Privilegije radnog mjesta";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 18;
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
            this.GumbIzlaz.TabIndex = 17;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablicna_privilegijaBindingSource
            // 
            this.tablicna_privilegijaBindingSource.DataMember = "tablicna_privilegija";
            this.tablicna_privilegijaBindingSource.DataSource = this.privremeniDS;
            // 
            // tablicna_privilegijaTableAdapter
            // 
            this.tablicna_privilegijaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tablicna_privilegijaTableAdapter = this.tablicna_privilegijaTableAdapter;
            this.tableAdapterManager.temeljnicaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voziloTableAdapter = null;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // radno_mjestoComboBox
            // 
            this.radno_mjestoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicna_privilegijaBindingSource, "radno_mjesto", true));
            this.radno_mjestoComboBox.FormattingEnabled = true;
            this.radno_mjestoComboBox.Location = new System.Drawing.Point(129, 51);
            this.radno_mjestoComboBox.Name = "radno_mjestoComboBox";
            this.radno_mjestoComboBox.Size = new System.Drawing.Size(121, 21);
            this.radno_mjestoComboBox.TabIndex = 20;
            // 
            // naziv_tabliceComboBox
            // 
            this.naziv_tabliceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicna_privilegijaBindingSource, "naziv_tablice", true));
            this.naziv_tabliceComboBox.FormattingEnabled = true;
            this.naziv_tabliceComboBox.Location = new System.Drawing.Point(129, 78);
            this.naziv_tabliceComboBox.Name = "naziv_tabliceComboBox";
            this.naziv_tabliceComboBox.Size = new System.Drawing.Size(121, 21);
            this.naziv_tabliceComboBox.TabIndex = 21;
            // 
            // operacijaComboBox
            // 
            this.operacijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablicna_privilegijaBindingSource, "operacija", true));
            this.operacijaComboBox.FormattingEnabled = true;
            this.operacijaComboBox.Location = new System.Drawing.Point(129, 105);
            this.operacijaComboBox.Name = "operacijaComboBox";
            this.operacijaComboBox.Size = new System.Drawing.Size(121, 21);
            this.operacijaComboBox.TabIndex = 22;
            // 
            // frmTablicaPrivilegija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(operacijaLabel);
            this.Controls.Add(this.operacijaComboBox);
            this.Controls.Add(naziv_tabliceLabel);
            this.Controls.Add(this.naziv_tabliceComboBox);
            this.Controls.Add(radno_mjestoLabel);
            this.Controls.Add(this.radno_mjestoComboBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovTablicaPrivilegija);
            this.Name = "frmTablicaPrivilegija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablicaPrivilegija";
            this.Load += new System.EventHandler(this.frmTablicaPrivilegija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablicna_privilegijaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovTablicaPrivilegija;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource tablicna_privilegijaBindingSource;
        private privremeniDSTableAdapters.tablicna_privilegijaTableAdapter tablicna_privilegijaTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox radno_mjestoComboBox;
        private System.Windows.Forms.ComboBox naziv_tabliceComboBox;
        private System.Windows.Forms.ComboBox operacijaComboBox;
    }
}