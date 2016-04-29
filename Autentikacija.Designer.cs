namespace kolnikApp
{
    partial class Autentikacija
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
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tipkaPrijava = new System.Windows.Forms.Button();
            this.tipkaRegistracija = new System.Windows.Forms.Button();
            this.tipkaIzlaz = new System.Windows.Forms.Button();
            this.cboxUdaljeneLokacije = new System.Windows.Forms.ComboBox();
            this.tipkaPrimijeni = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(158, 99);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(197, 22);
            this.tboxUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(158, 131);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(197, 22);
            this.tboxPassword.TabIndex = 3;
            // 
            // tipkaPrijava
            // 
            this.tipkaPrijava.Location = new System.Drawing.Point(52, 173);
            this.tipkaPrijava.Name = "tipkaPrijava";
            this.tipkaPrijava.Size = new System.Drawing.Size(90, 30);
            this.tipkaPrijava.TabIndex = 4;
            this.tipkaPrijava.Text = "Prijava";
            this.tipkaPrijava.UseVisualStyleBackColor = true;
            this.tipkaPrijava.Click += new System.EventHandler(this.tipkaPrijava_Click);
            // 
            // tipkaRegistracija
            // 
            this.tipkaRegistracija.Location = new System.Drawing.Point(158, 173);
            this.tipkaRegistracija.Name = "tipkaRegistracija";
            this.tipkaRegistracija.Size = new System.Drawing.Size(98, 30);
            this.tipkaRegistracija.TabIndex = 5;
            this.tipkaRegistracija.Text = "Registracija";
            this.tipkaRegistracija.UseVisualStyleBackColor = true;
            this.tipkaRegistracija.Click += new System.EventHandler(this.tipkaRegistracija_Click);
            // 
            // tipkaIzlaz
            // 
            this.tipkaIzlaz.Location = new System.Drawing.Point(274, 173);
            this.tipkaIzlaz.Name = "tipkaIzlaz";
            this.tipkaIzlaz.Size = new System.Drawing.Size(101, 30);
            this.tipkaIzlaz.TabIndex = 6;
            this.tipkaIzlaz.Text = "Izlaz";
            this.tipkaIzlaz.UseVisualStyleBackColor = true;
            this.tipkaIzlaz.Click += new System.EventHandler(this.tipkaIzlaz_Click);
            // 
            // cboxUdaljeneLokacije
            // 
            this.cboxUdaljeneLokacije.FormattingEnabled = true;
            this.cboxUdaljeneLokacije.Location = new System.Drawing.Point(219, 32);
            this.cboxUdaljeneLokacije.Name = "cboxUdaljeneLokacije";
            this.cboxUdaljeneLokacije.Size = new System.Drawing.Size(121, 24);
            this.cboxUdaljeneLokacije.TabIndex = 7;
            // 
            // tipkaPrimijeni
            // 
            this.tipkaPrimijeni.Location = new System.Drawing.Point(347, 32);
            this.tipkaPrimijeni.Name = "tipkaPrimijeni";
            this.tipkaPrimijeni.Size = new System.Drawing.Size(75, 24);
            this.tipkaPrimijeni.TabIndex = 8;
            this.tipkaPrimijeni.Text = "Primijeni";
            this.tipkaPrimijeni.UseVisualStyleBackColor = true;
            this.tipkaPrimijeni.Click += new System.EventHandler(this.tipkaPrimijeni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Putanja do spremišta podataka";
            // 
            // Autentikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipkaPrimijeni);
            this.Controls.Add(this.cboxUdaljeneLokacije);
            this.Controls.Add(this.tipkaIzlaz);
            this.Controls.Add(this.tipkaRegistracija);
            this.Controls.Add(this.tipkaPrijava);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxUsername);
            this.Name = "Autentikacija";
            this.Text = "Autentikacija";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Autentikacija_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Button tipkaPrijava;
        private System.Windows.Forms.Button tipkaRegistracija;
        private System.Windows.Forms.Button tipkaIzlaz;
        private System.Windows.Forms.ComboBox cboxUdaljeneLokacije;
        private System.Windows.Forms.Button tipkaPrimijeni;
        private System.Windows.Forms.Label label3;
    }
}

