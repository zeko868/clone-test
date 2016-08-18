namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmOtpremnica
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
            System.Windows.Forms.Label datum_otpremeLabel;
            System.Windows.Forms.Label otpremiteljLabel;
            System.Windows.Forms.Label temperaturaLabel;
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.NaslovOtpremnica = new System.Windows.Forms.Label();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.otpremnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpremnicaTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.otpremnicaTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.temeljnicaTextBox = new System.Windows.Forms.TextBox();
            this.datum_otpremeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.otpremiteljComboBox = new System.Windows.Forms.ComboBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            temeljnicaLabel = new System.Windows.Forms.Label();
            datum_otpremeLabel = new System.Windows.Forms.Label();
            otpremiteljLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // temeljnicaLabel
            // 
            temeljnicaLabel.AutoSize = true;
            temeljnicaLabel.Location = new System.Drawing.Point(66, 54);
            temeljnicaLabel.Name = "temeljnicaLabel";
            temeljnicaLabel.Size = new System.Drawing.Size(57, 13);
            temeljnicaLabel.TabIndex = 22;
            temeljnicaLabel.Text = "temeljnica:";
            // 
            // datum_otpremeLabel
            // 
            datum_otpremeLabel.AutoSize = true;
            datum_otpremeLabel.Location = new System.Drawing.Point(43, 81);
            datum_otpremeLabel.Name = "datum_otpremeLabel";
            datum_otpremeLabel.Size = new System.Drawing.Size(80, 13);
            datum_otpremeLabel.TabIndex = 23;
            datum_otpremeLabel.Text = "datum otpreme:";
            // 
            // otpremiteljLabel
            // 
            otpremiteljLabel.AutoSize = true;
            otpremiteljLabel.Location = new System.Drawing.Point(66, 106);
            otpremiteljLabel.Name = "otpremiteljLabel";
            otpremiteljLabel.Size = new System.Drawing.Size(57, 13);
            otpremiteljLabel.TabIndex = 25;
            otpremiteljLabel.Text = "otpremitelj:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(57, 133);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(66, 13);
            temperaturaLabel.TabIndex = 26;
            temperaturaLabel.Text = "temperatura:";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 169);
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
            this.GumbIzlaz.Location = new System.Drawing.Point(181, 169);
            this.GumbIzlaz.Name = "GumbIzlaz";
            this.GumbIzlaz.Size = new System.Drawing.Size(75, 23);
            this.GumbIzlaz.TabIndex = 17;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 169);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 16;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // NaslovOtpremnica
            // 
            this.NaslovOtpremnica.AutoSize = true;
            this.NaslovOtpremnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovOtpremnica.Location = new System.Drawing.Point(12, 9);
            this.NaslovOtpremnica.Name = "NaslovOtpremnica";
            this.NaslovOtpremnica.Size = new System.Drawing.Size(135, 26);
            this.NaslovOtpremnica.TabIndex = 21;
            this.NaslovOtpremnica.Text = "Otpremnica";
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otpremnicaBindingSource
            // 
            this.otpremnicaBindingSource.DataMember = "otpremnica";
            this.otpremnicaBindingSource.DataSource = this.privremeniDS;
            // 
            // otpremnicaTableAdapter
            // 
            this.otpremnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = null;
            this.tableAdapterManager.korisnicki_racunTableAdapter = null;
            this.tableAdapterManager.nalog_za_proizvodnjuTableAdapter = null;
            this.tableAdapterManager.narudzbenica_bitumenske_mjesavineTableAdapter = null;
            this.tableAdapterManager.otpremnicaTableAdapter = this.otpremnicaTableAdapter;
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
            this.temeljnicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otpremnicaBindingSource, "temeljnica", true));
            this.temeljnicaTextBox.Location = new System.Drawing.Point(129, 51);
            this.temeljnicaTextBox.Name = "temeljnicaTextBox";
            this.temeljnicaTextBox.Size = new System.Drawing.Size(143, 20);
            this.temeljnicaTextBox.TabIndex = 23;
            // 
            // datum_otpremeDateTimePicker
            // 
            this.datum_otpremeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.otpremnicaBindingSource, "datum_otpreme", true));
            this.datum_otpremeDateTimePicker.Location = new System.Drawing.Point(129, 77);
            this.datum_otpremeDateTimePicker.Name = "datum_otpremeDateTimePicker";
            this.datum_otpremeDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.datum_otpremeDateTimePicker.TabIndex = 24;
            // 
            // otpremiteljComboBox
            // 
            this.otpremiteljComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otpremnicaBindingSource, "otpremitelj", true));
            this.otpremiteljComboBox.FormattingEnabled = true;
            this.otpremiteljComboBox.Location = new System.Drawing.Point(129, 103);
            this.otpremiteljComboBox.Name = "otpremiteljComboBox";
            this.otpremiteljComboBox.Size = new System.Drawing.Size(143, 21);
            this.otpremiteljComboBox.TabIndex = 26;
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.otpremnicaBindingSource, "temperatura", true));
            this.temperaturaTextBox.Location = new System.Drawing.Point(129, 130);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(143, 20);
            this.temperaturaTextBox.TabIndex = 27;
            // 
            // frmOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(temperaturaLabel);
            this.Controls.Add(this.temperaturaTextBox);
            this.Controls.Add(otpremiteljLabel);
            this.Controls.Add(this.otpremiteljComboBox);
            this.Controls.Add(datum_otpremeLabel);
            this.Controls.Add(this.datum_otpremeDateTimePicker);
            this.Controls.Add(temeljnicaLabel);
            this.Controls.Add(this.temeljnicaTextBox);
            this.Controls.Add(this.NaslovOtpremnica);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Name = "frmOtpremnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOtpremnica";
            this.Load += new System.EventHandler(this.frmOtpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpremnicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private System.Windows.Forms.Label NaslovOtpremnica;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource otpremnicaBindingSource;
        private privremeniDSTableAdapters.otpremnicaTableAdapter otpremnicaTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox temeljnicaTextBox;
        private System.Windows.Forms.DateTimePicker datum_otpremeDateTimePicker;
        private System.Windows.Forms.ComboBox otpremiteljComboBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
    }
}