namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmGradiliste
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
            System.Windows.Forms.Label naziv_mjestaLabel;
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.gradilisteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradilisteTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.gradilisteTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.naziv_mjestaTextBox = new System.Windows.Forms.TextBox();
            this.NaslovGradiliste = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            naziv_mjestaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilisteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // naziv_mjestaLabel
            // 
            naziv_mjestaLabel.AutoSize = true;
            naziv_mjestaLabel.Location = new System.Drawing.Point(48, 57);
            naziv_mjestaLabel.Name = "naziv_mjestaLabel";
            naziv_mjestaLabel.Size = new System.Drawing.Size(68, 13);
            naziv_mjestaLabel.TabIndex = 1;
            naziv_mjestaLabel.Text = "naziv mjesta:";
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradilisteBindingSource
            // 
            this.gradilisteBindingSource.DataMember = "gradiliste";
            this.gradilisteBindingSource.DataSource = this.privremeniDS;
            // 
            // gradilisteTableAdapter
            // 
            this.gradilisteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = this.gradilisteTableAdapter;
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
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // naziv_mjestaTextBox
            // 
            this.naziv_mjestaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gradilisteBindingSource, "naziv_mjesta", true));
            this.naziv_mjestaTextBox.Location = new System.Drawing.Point(122, 54);
            this.naziv_mjestaTextBox.Name = "naziv_mjestaTextBox";
            this.naziv_mjestaTextBox.Size = new System.Drawing.Size(100, 20);
            this.naziv_mjestaTextBox.TabIndex = 2;
            // 
            // NaslovGradiliste
            // 
            this.NaslovGradiliste.AutoSize = true;
            this.NaslovGradiliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovGradiliste.Location = new System.Drawing.Point(12, 9);
            this.NaslovGradiliste.Name = "NaslovGradiliste";
            this.NaslovGradiliste.Size = new System.Drawing.Size(114, 26);
            this.NaslovGradiliste.TabIndex = 7;
            this.NaslovGradiliste.Text = "Gradilište";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 90);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 90);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 90);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 10;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // frmGradiliste
            // 
            this.AcceptButton = this.GumbPotvrda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovGradiliste);
            this.Controls.Add(naziv_mjestaLabel);
            this.Controls.Add(this.naziv_mjestaTextBox);
            this.Name = "frmGradiliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGradiliste";
            this.Load += new System.EventHandler(this.frmGradiliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradilisteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource gradilisteBindingSource;
        private privremeniDSTableAdapters.gradilisteTableAdapter gradilisteTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox naziv_mjestaTextBox;
        private System.Windows.Forms.Label NaslovGradiliste;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
    }
}