namespace kolnikApp
{
    partial class Registracija
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxPrezime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxOIB = new System.Windows.Forms.TextBox();
            this.tipkaRegistracija = new System.Windows.Forms.Button();
            this.tipkaOdustani = new System.Windows.Forms.Button();
            this.tboxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(114, 19);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(180, 22);
            this.tboxUsername.TabIndex = 1;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(114, 47);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(180, 22);
            this.tboxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "OIB:";
            // 
            // tboxIme
            // 
            this.tboxIme.Location = new System.Drawing.Point(114, 132);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(180, 22);
            this.tboxIme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ime";
            // 
            // tboxPrezime
            // 
            this.tboxPrezime.Location = new System.Drawing.Point(114, 160);
            this.tboxPrezime.Name = "tboxPrezime";
            this.tboxPrezime.Size = new System.Drawing.Size(180, 22);
            this.tboxPrezime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prezime";
            // 
            // tboxOIB
            // 
            this.tboxOIB.Location = new System.Drawing.Point(114, 104);
            this.tboxOIB.MaxLength = 11;
            this.tboxOIB.Name = "tboxOIB";
            this.tboxOIB.Size = new System.Drawing.Size(180, 22);
            this.tboxOIB.TabIndex = 5;
            this.tboxOIB.TextChanged += new System.EventHandler(this.tboxOIB_TextChanged);
            // 
            // tipkaRegistracija
            // 
            this.tipkaRegistracija.Location = new System.Drawing.Point(80, 200);
            this.tipkaRegistracija.Name = "tipkaRegistracija";
            this.tipkaRegistracija.Size = new System.Drawing.Size(102, 30);
            this.tipkaRegistracija.TabIndex = 10;
            this.tipkaRegistracija.Text = "Registriraj se!";
            this.tipkaRegistracija.UseVisualStyleBackColor = true;
            this.tipkaRegistracija.Click += new System.EventHandler(this.tipkaRegistracija_Click);
            // 
            // tipkaOdustani
            // 
            this.tipkaOdustani.Location = new System.Drawing.Point(203, 200);
            this.tipkaOdustani.Name = "tipkaOdustani";
            this.tipkaOdustani.Size = new System.Drawing.Size(98, 30);
            this.tipkaOdustani.TabIndex = 11;
            this.tipkaOdustani.Text = "Odustani";
            this.tipkaOdustani.UseVisualStyleBackColor = true;
            this.tipkaOdustani.Click += new System.EventHandler(this.tipkaOdustani_Click);
            // 
            // tboxRepeatPassword
            // 
            this.tboxRepeatPassword.Location = new System.Drawing.Point(114, 75);
            this.tboxRepeatPassword.Name = "tboxRepeatPassword";
            this.tboxRepeatPassword.PasswordChar = '*';
            this.tboxRepeatPassword.Size = new System.Drawing.Size(180, 22);
            this.tboxRepeatPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ponovljen unos";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 254);
            this.Controls.Add(this.tboxRepeatPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipkaOdustani);
            this.Controls.Add(this.tipkaRegistracija);
            this.Controls.Add(this.tboxPrezime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxOIB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.Text = "Registracijski obrazac";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Registracija_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxPrezime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxOIB;
        private System.Windows.Forms.Button tipkaRegistracija;
        private System.Windows.Forms.Button tipkaOdustani;
        private System.Windows.Forms.TextBox tboxRepeatPassword;
        private System.Windows.Forms.Label label6;
    }
}