namespace kolnikApp_klijent.FormeZaUnos
{
    partial class frmKorisnickiRacun
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
            System.Windows.Forms.Label zaposlenikLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label lozinkaLabel;
            this.NaslovKorisnickiRacun = new System.Windows.Forms.Label();
            this.privremeniDS = new kolnikApp_klijent.privremeniDS();
            this.korisnicki_racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnicki_racunTableAdapter = new kolnikApp_klijent.privremeniDSTableAdapters.korisnicki_racunTableAdapter();
            this.tableAdapterManager = new kolnikApp_klijent.privremeniDSTableAdapters.TableAdapterManager();
            this.zaposlenikTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.GumbReset = new System.Windows.Forms.Button();
            this.GumbIzlaz = new System.Windows.Forms.Button();
            this.GumbPotvrda = new System.Windows.Forms.Button();
            zaposlenikLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnicki_racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zaposlenikLabel
            // 
            zaposlenikLabel.AutoSize = true;
            zaposlenikLabel.Location = new System.Drawing.Point(63, 54);
            zaposlenikLabel.Name = "zaposlenikLabel";
            zaposlenikLabel.Size = new System.Drawing.Size(60, 13);
            zaposlenikLabel.TabIndex = 9;
            zaposlenikLabel.Text = "zaposlenik:";
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(46, 80);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(77, 13);
            korisnicko_imeLabel.TabIndex = 10;
            korisnicko_imeLabel.Text = "korisnicko ime:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(80, 106);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(43, 13);
            lozinkaLabel.TabIndex = 11;
            lozinkaLabel.Text = "lozinka:";
            // 
            // NaslovKorisnickiRacun
            // 
            this.NaslovKorisnickiRacun.AutoSize = true;
            this.NaslovKorisnickiRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovKorisnickiRacun.Location = new System.Drawing.Point(12, 9);
            this.NaslovKorisnickiRacun.Name = "NaslovKorisnickiRacun";
            this.NaslovKorisnickiRacun.Size = new System.Drawing.Size(182, 26);
            this.NaslovKorisnickiRacun.TabIndex = 8;
            this.NaslovKorisnickiRacun.Text = "Korisnički račun";
            // 
            // privremeniDS
            // 
            this.privremeniDS.DataSetName = "privremeniDS";
            this.privremeniDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnicki_racunBindingSource
            // 
            this.korisnicki_racunBindingSource.DataMember = "korisnicki_racun";
            this.korisnicki_racunBindingSource.DataSource = this.privremeniDS;
            // 
            // korisnicki_racunTableAdapter
            // 
            this.korisnicki_racunTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.artiklTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gradilisteTableAdapter = null;
            this.tableAdapterManager.korisnicki_racunTableAdapter = this.korisnicki_racunTableAdapter;
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
            // zaposlenikTextBox
            // 
            this.zaposlenikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnicki_racunBindingSource, "zaposlenik", true));
            this.zaposlenikTextBox.Location = new System.Drawing.Point(129, 51);
            this.zaposlenikTextBox.Name = "zaposlenikTextBox";
            this.zaposlenikTextBox.Size = new System.Drawing.Size(100, 20);
            this.zaposlenikTextBox.TabIndex = 10;
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnicki_racunBindingSource, "korisnicko_ime", true));
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(129, 77);
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnicko_imeTextBox.TabIndex = 11;
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnicki_racunBindingSource, "lozinka", true));
            this.lozinkaTextBox.Location = new System.Drawing.Point(129, 103);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(100, 20);
            this.lozinkaTextBox.TabIndex = 12;
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
            // frmKorisnickiRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.GumbIzlaz;
            this.ClientSize = new System.Drawing.Size(349, 261);
            this.ControlBox = false;
            this.Controls.Add(this.GumbReset);
            this.Controls.Add(this.GumbIzlaz);
            this.Controls.Add(this.GumbPotvrda);
            this.Controls.Add(lozinkaLabel);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.korisnicko_imeTextBox);
            this.Controls.Add(zaposlenikLabel);
            this.Controls.Add(this.zaposlenikTextBox);
            this.Controls.Add(this.NaslovKorisnickiRacun);
            this.Name = "frmKorisnickiRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisnickiRacun";
            this.Load += new System.EventHandler(this.frmKorisnickiRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privremeniDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnicki_racunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NaslovKorisnickiRacun;
        private privremeniDS privremeniDS;
        private System.Windows.Forms.BindingSource korisnicki_racunBindingSource;
        private privremeniDSTableAdapters.korisnicki_racunTableAdapter korisnicki_racunTableAdapter;
        private privremeniDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox zaposlenikTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button GumbReset;
        private System.Windows.Forms.Button GumbIzlaz;
        private System.Windows.Forms.Button GumbPotvrda;
    }
}