namespace kolnikApp
{
    partial class UnosOtpremnica
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
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipkaOsvjezi = new System.Windows.Forms.Button();
            this.popisTemeljnica = new System.Windows.Forms.DataGridView();
            this.sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artikl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regoznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreirajOtpremnicu = new System.Windows.Forms.Button();
            this.ocistiOtpremnicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisTemeljnica)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(103, 288);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(200, 22);
            this.inputDatum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vrijeme:";
            // 
            // tboxVrijeme
            // 
            this.tboxVrijeme.Location = new System.Drawing.Point(103, 319);
            this.tboxVrijeme.Name = "tboxVrijeme";
            this.tboxVrijeme.Size = new System.Drawing.Size(100, 22);
            this.tboxVrijeme.TabIndex = 8;
            this.tboxVrijeme.Enter += new System.EventHandler(this.tboxVrijeme_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Odaberite temeljnicu:";
            // 
            // tipkaOsvjezi
            // 
            this.tipkaOsvjezi.Location = new System.Drawing.Point(180, 81);
            this.tipkaOsvjezi.Name = "tipkaOsvjezi";
            this.tipkaOsvjezi.Size = new System.Drawing.Size(123, 27);
            this.tipkaOsvjezi.TabIndex = 11;
            this.tipkaOsvjezi.Text = "Osvježi popis";
            this.tipkaOsvjezi.UseVisualStyleBackColor = true;
            this.tipkaOsvjezi.Click += new System.EventHandler(this.tipkaOsvjezi_Click);
            // 
            // popisTemeljnica
            // 
            this.popisTemeljnica.AllowUserToAddRows = false;
            this.popisTemeljnica.AllowUserToDeleteRows = false;
            this.popisTemeljnica.AllowUserToOrderColumns = true;
            this.popisTemeljnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisTemeljnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sifra,
            this.tip,
            this.oib,
            this.naziv,
            this.artikl,
            this.kolicina,
            this.datum,
            this.vozac,
            this.regoznaka});
            this.popisTemeljnica.Location = new System.Drawing.Point(21, 110);
            this.popisTemeljnica.MultiSelect = false;
            this.popisTemeljnica.Name = "popisTemeljnica";
            this.popisTemeljnica.ReadOnly = true;
            this.popisTemeljnica.RowHeadersVisible = false;
            this.popisTemeljnica.RowTemplate.Height = 24;
            this.popisTemeljnica.Size = new System.Drawing.Size(800, 156);
            this.popisTemeljnica.TabIndex = 14;
            // 
            // sifra
            // 
            this.sifra.HeaderText = "Šifra temeljnice";
            this.sifra.Name = "sifra";
            this.sifra.ReadOnly = true;
            this.sifra.Width = 75;
            // 
            // tip
            // 
            this.tip.HeaderText = "Tip temeljnice";
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 75;
            // 
            // oib
            // 
            this.oib.HeaderText = "OIB zahtjevatelja";
            this.oib.Name = "oib";
            this.oib.ReadOnly = true;
            this.oib.Width = 87;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv zahtjevatelja";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // artikl
            // 
            this.artikl.HeaderText = "Artikl";
            this.artikl.Name = "artikl";
            this.artikl.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.HeaderText = "Količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.Width = 60;
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum zahtjevanja";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // vozac
            // 
            this.vozac.HeaderText = "Naziv vozača";
            this.vozac.Name = "vozac";
            this.vozac.ReadOnly = true;
            // 
            // regoznaka
            // 
            this.regoznaka.HeaderText = "Reg. oznaka";
            this.regoznaka.Name = "regoznaka";
            this.regoznaka.ReadOnly = true;
            // 
            // kreirajOtpremnicu
            // 
            this.kreirajOtpremnicu.Location = new System.Drawing.Point(544, 315);
            this.kreirajOtpremnicu.Name = "kreirajOtpremnicu";
            this.kreirajOtpremnicu.Size = new System.Drawing.Size(75, 26);
            this.kreirajOtpremnicu.TabIndex = 15;
            this.kreirajOtpremnicu.Text = "Izdaj";
            this.kreirajOtpremnicu.UseVisualStyleBackColor = true;
            this.kreirajOtpremnicu.Click += new System.EventHandler(this.kreirajOtpremnicu_Click);
            // 
            // ocistiOtpremnicu
            // 
            this.ocistiOtpremnicu.Location = new System.Drawing.Point(626, 314);
            this.ocistiOtpremnicu.Name = "ocistiOtpremnicu";
            this.ocistiOtpremnicu.Size = new System.Drawing.Size(75, 27);
            this.ocistiOtpremnicu.TabIndex = 16;
            this.ocistiOtpremnicu.Text = "Očisti";
            this.ocistiOtpremnicu.UseVisualStyleBackColor = true;
            this.ocistiOtpremnicu.Click += new System.EventHandler(this.ocistiOtpremnicu_Click);
            // 
            // UnosOtpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 359);
            this.Controls.Add(this.ocistiOtpremnicu);
            this.Controls.Add(this.kreirajOtpremnicu);
            this.Controls.Add(this.popisTemeljnica);
            this.Controls.Add(this.tipkaOsvjezi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxVrijeme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDatum);
            this.Name = "UnosOtpremnica";
            this.Text = "UnosOtpremnica";
            this.Load += new System.EventHandler(this.UnosOtpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisTemeljnica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxVrijeme;
        private System.Windows.Forms.Button tipkaOsvjezi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView popisTemeljnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozac;
        private System.Windows.Forms.DataGridViewTextBoxColumn regoznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn artikl;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifra;
        private System.Windows.Forms.Button kreirajOtpremnicu;
        private System.Windows.Forms.Button ocistiOtpremnicu;
    }
}