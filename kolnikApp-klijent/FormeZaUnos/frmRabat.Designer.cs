namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmRabat
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
            System.Windows.Forms.Label popustLabel;
            System.Windows.Forms.Label artiklLabel;
            System.Windows.Forms.Label poslovni_partnerLabel;
            this.NaslovRabat = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.rabatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rabatTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.rabatTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.popustTextBox = new System.Windows.Forms.TextBox();
            this.artiklComboBox = new System.Windows.Forms.ComboBox();
            this.poslovni_partnerComboBox = new System.Windows.Forms.ComboBox();
            popustLabel = new System.Windows.Forms.Label();
            artiklLabel = new System.Windows.Forms.Label();
            poslovni_partnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // popustLabel
            // 
            popustLabel.AutoSize = true;
            popustLabel.Location = new System.Drawing.Point(81, 108);
            popustLabel.Name = "popustLabel";
            popustLabel.Size = new System.Drawing.Size(42, 13);
            popustLabel.TabIndex = 20;
            popustLabel.Text = "popust:";
            // 
            // artiklLabel
            // 
            artiklLabel.AutoSize = true;
            artiklLabel.Location = new System.Drawing.Point(91, 54);
            artiklLabel.Name = "artiklLabel";
            artiklLabel.Size = new System.Drawing.Size(32, 13);
            artiklLabel.TabIndex = 21;
            artiklLabel.Text = "artikl:";
            // 
            // poslovni_partnerLabel
            // 
            poslovni_partnerLabel.AutoSize = true;
            poslovni_partnerLabel.Location = new System.Drawing.Point(38, 81);
            poslovni_partnerLabel.Name = "poslovni_partnerLabel";
            poslovni_partnerLabel.Size = new System.Drawing.Size(85, 13);
            poslovni_partnerLabel.TabIndex = 22;
            poslovni_partnerLabel.Text = "poslovni partner:";
            // 
            // NaslovRabat
            // 
            this.NaslovRabat.AutoSize = true;
            this.NaslovRabat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovRabat.Location = new System.Drawing.Point(12, 9);
            this.NaslovRabat.Name = "NaslovRabat";
            this.NaslovRabat.Size = new System.Drawing.Size(75, 26);
            this.NaslovRabat.TabIndex = 14;
            this.NaslovRabat.Text = "Rabat";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 17;
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
            this.GumbIzlaz.TabIndex = 16;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 15;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rabatBindingSource
            // 
            this.rabatBindingSource.DataMember = "rabat";
            this.rabatBindingSource.DataSource = this.privremeniDS;
            // 
            // rabatTableAdapter
            // 
            this.rabatTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.rabatTableAdapter = this.rabatTableAdapter;
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
            // popustTextBox
            // 
            this.popustTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabatBindingSource, "popust", true));
            this.popustTextBox.Location = new System.Drawing.Point(129, 105);
            this.popustTextBox.Name = "popustTextBox";
            this.popustTextBox.Size = new System.Drawing.Size(121, 20);
            this.popustTextBox.TabIndex = 21;
            // 
            // artiklComboBox
            // 
            this.artiklComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabatBindingSource, "artikl", true));
            this.artiklComboBox.FormattingEnabled = true;
            this.artiklComboBox.Location = new System.Drawing.Point(129, 51);
            this.artiklComboBox.Name = "artiklComboBox";
            this.artiklComboBox.Size = new System.Drawing.Size(121, 21);
            this.artiklComboBox.TabIndex = 22;
            // 
            // poslovni_partnerComboBox
            // 
            this.poslovni_partnerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rabatBindingSource, "poslovni_partner", true));
            this.poslovni_partnerComboBox.FormattingEnabled = true;
            this.poslovni_partnerComboBox.Location = new System.Drawing.Point(129, 78);
            this.poslovni_partnerComboBox.Name = "poslovni_partnerComboBox";
            this.poslovni_partnerComboBox.Size = new System.Drawing.Size(121, 21);
            this.poslovni_partnerComboBox.TabIndex = 23;
            // 
            // frmRabat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(poslovni_partnerLabel);
            this.Controls.Add(this.poslovni_partnerComboBox);
            this.Controls.Add(artiklLabel);
            this.Controls.Add(this.artiklComboBox);
            this.Controls.Add(popustLabel);
            this.Controls.Add(this.popustTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovRabat);
            this.Name = "frmRabat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRabat";
            this.Load += new System.EventHandler(this.frmRabat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rabatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovRabat;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource rabatBindingSource;
        private privremeniDSTableAdapters.rabatTableAdapter rabatTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox popustTextBox;
        private System.Windows.Forms.ComboBox artiklComboBox;
        private System.Windows.Forms.ComboBox poslovni_partnerComboBox;
    }
}