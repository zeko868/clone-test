namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmZaposlenik
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
            System.Windows.Forms.Label oibLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            this.NaslovZaposlenik = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.zaposlenikTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            oibLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NaslovZaposlenik
            // 
            this.NaslovZaposlenik.AutoSize = true;
            this.NaslovZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovZaposlenik.Location = new System.Drawing.Point(12, 9);
            this.NaslovZaposlenik.Name = "NaslovZaposlenik";
            this.NaslovZaposlenik.Size = new System.Drawing.Size(127, 26);
            this.NaslovZaposlenik.TabIndex = 13;
            this.NaslovZaposlenik.Text = "Zaposlenik";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 144);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 26;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
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
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataMember = "zaposlenik";
            this.zaposlenikBindingSource.DataSource = this.privremeniDS;
            // 
            // zaposlenikTableAdapter
            // 
            this.zaposlenikTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.zaposlenikTableAdapter = this.zaposlenikTableAdapter;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(99, 54);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(24, 13);
            oibLabel.TabIndex = 28;
            oibLabel.Text = "oib:";
            // 
            // oibTextBox
            // 
            this.oibTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "oib", true));
            this.oibTextBox.Location = new System.Drawing.Point(129, 51);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(126, 20);
            this.oibTextBox.TabIndex = 29;
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(97, 80);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(26, 13);
            imeLabel.TabIndex = 29;
            imeLabel.Text = "ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(129, 77);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(126, 20);
            this.imeTextBox.TabIndex = 30;
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(77, 106);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(46, 13);
            prezimeLabel.TabIndex = 30;
            prezimeLabel.Text = "prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zaposlenikBindingSource, "prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(129, 103);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(126, 20);
            this.prezimeTextBox.TabIndex = 31;
            // 
            // frmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbPotvrda;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(oibLabel);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovZaposlenik);
            this.Name = "frmZaposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmZaposlenik";
            this.Load += new System.EventHandler(this.frmZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovZaposlenik;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private privremeniDSTableAdapters.zaposlenikTableAdapter zaposlenikTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
    }
}