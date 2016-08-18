namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmPoduzece
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label ibanLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovPoduzece = new System.Windows.Forms.Label();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.poduzeceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poduzeceTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.poduzeceTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            oibLabel = new System.Windows.Forms.Label();
            nazivLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            ibanLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poduzeceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oibLabel
            // 
            oibLabel.AutoSize = true;
            oibLabel.Location = new System.Drawing.Point(99, 54);
            oibLabel.Name = "oibLabel";
            oibLabel.Size = new System.Drawing.Size(24, 13);
            oibLabel.TabIndex = 14;
            oibLabel.Text = "oib:";
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(88, 80);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(35, 13);
            nazivLabel.TabIndex = 15;
            nazivLabel.Text = "naziv:";
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(81, 106);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(42, 13);
            adresaLabel.TabIndex = 16;
            adresaLabel.Text = "adresa:";
            // 
            // ibanLabel
            // 
            ibanLabel.AutoSize = true;
            ibanLabel.Location = new System.Drawing.Point(93, 132);
            ibanLabel.Name = "ibanLabel";
            ibanLabel.Size = new System.Drawing.Size(30, 13);
            ibanLabel.TabIndex = 17;
            ibanLabel.Text = "iban:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 169);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 11;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 10;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // NaslovPoduzece
            // 
            this.NaslovPoduzece.AutoSize = true;
            this.NaslovPoduzece.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovPoduzece.Location = new System.Drawing.Point(12, 9);
            this.NaslovPoduzece.Name = "NaslovPoduzece";
            this.NaslovPoduzece.Size = new System.Drawing.Size(117, 26);
            this.NaslovPoduzece.TabIndex = 13;
            this.NaslovPoduzece.Text = "Poduzeće";
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poduzeceBindingSource
            // 
            this.poduzeceBindingSource.DataMember = "poduzece";
            this.poduzeceBindingSource.DataSource = this.privremeniDS;
            // 
            // poduzeceTableAdapter
            // 
            this.poduzeceTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.poduzeceTableAdapter = this.poduzeceTableAdapter;
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
            // oibTextBox
            // 
            this.oibTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poduzeceBindingSource, "oib", true));
            this.oibTextBox.Location = new System.Drawing.Point(129, 51);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(100, 20);
            this.oibTextBox.TabIndex = 15;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poduzeceBindingSource, "naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(129, 77);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 16;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poduzeceBindingSource, "adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(129, 103);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 17;
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poduzeceBindingSource, "iban", true));
            this.ibanTextBox.Location = new System.Drawing.Point(129, 129);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(100, 20);
            this.ibanTextBox.TabIndex = 18;
            // 
            // frmPoduzece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(ibanLabel);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(oibLabel);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.NaslovPoduzece);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Name = "frmPoduzece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoduzece";
            this.Load += new System.EventHandler(this.frmPoduzece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poduzeceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovPoduzece;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource poduzeceBindingSource;
        private privremeniDSTableAdapters.poduzeceTableAdapter poduzeceTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox ibanTextBox;
    }
}