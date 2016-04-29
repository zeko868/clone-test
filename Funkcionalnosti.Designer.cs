namespace kolnikApp
{
    partial class Funkcionalnosti
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
            this.listaFunkcionalnosti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.tipkaKoristi = new System.Windows.Forms.Button();
            this.labelGrupa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaFunkcionalnosti
            // 
            this.listaFunkcionalnosti.FormattingEnabled = true;
            this.listaFunkcionalnosti.ItemHeight = 16;
            this.listaFunkcionalnosti.Location = new System.Drawing.Point(12, 141);
            this.listaFunkcionalnosti.Name = "listaFunkcionalnosti";
            this.listaFunkcionalnosti.Size = new System.Drawing.Size(277, 100);
            this.listaFunkcionalnosti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite funkcionalnost koju želite koristiti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prijavljeni ste kao: ";
            // 
            // labelNaziv
            // 
            this.labelNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaziv.Location = new System.Drawing.Point(93, 34);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(105, 25);
            this.labelNaziv.TabIndex = 3;
            this.labelNaziv.Text = "plaintesdxt";
            this.labelNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipkaKoristi
            // 
            this.tipkaKoristi.Location = new System.Drawing.Point(71, 247);
            this.tipkaKoristi.Name = "tipkaKoristi";
            this.tipkaKoristi.Size = new System.Drawing.Size(147, 33);
            this.tipkaKoristi.TabIndex = 4;
            this.tipkaKoristi.Text = "Počni sa korištenjem";
            this.tipkaKoristi.UseVisualStyleBackColor = true;
            // 
            // labelGrupa
            // 
            this.labelGrupa.AutoSize = true;
            this.labelGrupa.Location = new System.Drawing.Point(13, 81);
            this.labelGrupa.Name = "labelGrupa";
            this.labelGrupa.Size = new System.Drawing.Size(46, 17);
            this.labelGrupa.TabIndex = 5;
            this.labelGrupa.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 285);
            this.Controls.Add(this.labelGrupa);
            this.Controls.Add(this.tipkaKoristi);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaFunkcionalnosti);
            this.Name = "Form1";
            this.Text = "Funkcionalnosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaFunkcionalnosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button tipkaKoristi;
        private System.Windows.Forms.Label labelGrupa;
    }
}