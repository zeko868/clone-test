namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmVozilo
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
            System.Windows.Forms.Label registracijski_brojLabel;
            System.Windows.Forms.Label proizvodjacLabel;
            System.Windows.Forms.Label modelLabel;
            this.NaslovVozilo = new System.Windows.Forms.Label();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.voziloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.voziloTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.registracijski_brojTextBox = new System.Windows.Forms.TextBox();
            this.proizvodjacTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            registracijski_brojLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registracijski_brojLabel
            // 
            registracijski_brojLabel.AutoSize = true;
            registracijski_brojLabel.Location = new System.Drawing.Point(36, 54);
            registracijski_brojLabel.Name = "registracijski_brojLabel";
            registracijski_brojLabel.Size = new System.Drawing.Size(87, 13);
            registracijski_brojLabel.TabIndex = 25;
            registracijski_brojLabel.Text = "registracijski broj:";
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(59, 80);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(64, 13);
            proizvodjacLabel.TabIndex = 26;
            proizvodjacLabel.Text = "proizvodjac:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(85, 106);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(38, 13);
            modelLabel.TabIndex = 27;
            modelLabel.Text = "model:";
            // 
            // NaslovVozilo
            // 
            this.NaslovVozilo.AutoSize = true;
            this.NaslovVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovVozilo.Location = new System.Drawing.Point(12, 9);
            this.NaslovVozilo.Name = "NaslovVozilo";
            this.NaslovVozilo.Size = new System.Drawing.Size(78, 26);
            this.NaslovVozilo.TabIndex = 12;
            this.NaslovVozilo.Text = "Vozilo";
            // 
            // GumbReset
            // 
            this.GumbReset.Location = new System.Drawing.Point(262, 144);
            this.GumbReset.Name = "GumbReset";
            this.GumbReset.Size = new System.Drawing.Size(75, 23);
            this.GumbReset.TabIndex = 24;
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
            this.GumbIzlaz.TabIndex = 23;
            this.GumbIzlaz.Text = "Cancel";
            this.GumbIzlaz.UseVisualStyleBackColor = true;
            this.GumbIzlaz.Click += new System.EventHandler(this.GumbIzlaz_Click);
            // 
            // GumbPotvrda
            // 
            this.GumbPotvrda.Location = new System.Drawing.Point(100, 144);
            this.GumbPotvrda.Name = "GumbPotvrda";
            this.GumbPotvrda.Size = new System.Drawing.Size(75, 23);
            this.GumbPotvrda.TabIndex = 22;
            this.GumbPotvrda.Text = "Ok";
            this.GumbPotvrda.UseVisualStyleBackColor = true;
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voziloBindingSource
            // 
            this.voziloBindingSource.DataMember = "vozilo";
            this.voziloBindingSource.DataSource = this.privremeniDS;
            // 
            // voziloTableAdapter
            // 
            this.voziloTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.voziloTableAdapter = this.voziloTableAdapter;
            this.tableAdapterManager.voziTableAdapter = null;
            this.tableAdapterManager.zaposlenikTableAdapter = null;
            this.tableAdapterManager.zaposlenTableAdapter = null;
            // 
            // registracijski_brojTextBox
            // 
            this.registracijski_brojTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "registracijski_broj", true));
            this.registracijski_brojTextBox.Location = new System.Drawing.Point(129, 51);
            this.registracijski_brojTextBox.Name = "registracijski_brojTextBox";
            this.registracijski_brojTextBox.Size = new System.Drawing.Size(127, 20);
            this.registracijski_brojTextBox.TabIndex = 26;
            // 
            // proizvodjacTextBox
            // 
            this.proizvodjacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "proizvodjac", true));
            this.proizvodjacTextBox.Location = new System.Drawing.Point(129, 77);
            this.proizvodjacTextBox.Name = "proizvodjacTextBox";
            this.proizvodjacTextBox.Size = new System.Drawing.Size(127, 20);
            this.proizvodjacTextBox.TabIndex = 27;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voziloBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(129, 103);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(127, 20);
            this.modelTextBox.TabIndex = 28;
            // 
            // frmVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.ControlBox = false;
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(proizvodjacLabel);
            this.Controls.Add(this.proizvodjacTextBox);
            this.Controls.Add(registracijski_brojLabel);
            this.Controls.Add(this.registracijski_brojTextBox);
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(this.NaslovVozilo);
            this.Name = "frmVozilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVozilo";
            this.Load += new System.EventHandler(this.frmVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovVozilo;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource voziloBindingSource;
        private privremeniDSTableAdapters.voziloTableAdapter voziloTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox registracijski_brojTextBox;
        private System.Windows.Forms.TextBox proizvodjacTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
    }
}