namespace kolnikApp_klijent
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.korisnickoIme = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.kolnikApp = new System.Windows.Forms.Label();
            this.loginGumb = new System.Windows.Forms.Button();
            this.loginTypeLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.AutoSize = true;
            this.korisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnickoIme.Location = new System.Drawing.Point(267, 128);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(98, 16);
            this.korisnickoIme.TabIndex = 3;
            this.korisnickoIme.Text = "Korisničko ime:";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinka.Location = new System.Drawing.Point(267, 190);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(57, 16);
            this.lozinka.TabIndex = 4;
            this.lozinka.Text = "Lozinka:";
            // 
            // kolnikApp
            // 
            this.kolnikApp.AutoSize = true;
            this.kolnikApp.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolnikApp.Location = new System.Drawing.Point(302, 59);
            this.kolnikApp.Name = "kolnikApp";
            this.kolnikApp.Size = new System.Drawing.Size(157, 40);
            this.kolnikApp.TabIndex = 5;
            this.kolnikApp.Text = "KolnikApp";
            // 
            // loginGumb
            // 
            this.loginGumb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginGumb.Location = new System.Drawing.Point(309, 266);
            this.loginGumb.Name = "loginGumb";
            this.loginGumb.Size = new System.Drawing.Size(150, 50);
            this.loginGumb.TabIndex = 2;
            this.loginGumb.Text = "Login";
            this.loginGumb.UseVisualStyleBackColor = true;
            this.loginGumb.Click += new System.EventHandler(this.loginGumb_Click);
            // 
            // loginTypeLabel
            // 
            this.loginTypeLabel.AutoSize = true;
            this.loginTypeLabel.Location = new System.Drawing.Point(268, 165);
            this.loginTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginTypeLabel.Name = "loginTypeLabel";
            this.loginTypeLabel.Size = new System.Drawing.Size(135, 13);
            this.loginTypeLabel.TabIndex = 6;
            this.loginTypeLabel.TabStop = true;
            this.loginTypeLabel.Text = "Prijavi se korištenjem OIB-a";
            this.loginTypeLabel.Click += new System.EventHandler(this.loginType_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginGumb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.loginTypeLabel);
            this.Controls.Add(this.kolnikApp);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.loginGumb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label korisnickoIme;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.Label kolnikApp;
        private System.Windows.Forms.Button loginGumb;
        private System.Windows.Forms.LinkLabel loginTypeLabel;
    }
}