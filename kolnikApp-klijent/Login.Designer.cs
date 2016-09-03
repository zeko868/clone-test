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
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Size = new System.Drawing.Size(1045, 33);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(925, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(966, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1008, 0);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(356, 177);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(356, 254);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.korisnickoIme.AutoSize = true;
            this.korisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnickoIme.ForeColor = System.Drawing.Color.White;
            this.korisnickoIme.Location = new System.Drawing.Point(356, 158);
            this.korisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(124, 20);
            this.korisnickoIme.TabIndex = 3;
            this.korisnickoIme.Text = "Korisničko ime:";
            // 
            // lozinka
            // 
            this.lozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lozinka.AutoSize = true;
            this.lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinka.ForeColor = System.Drawing.Color.White;
            this.lozinka.Location = new System.Drawing.Point(356, 234);
            this.lozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(72, 20);
            this.lozinka.TabIndex = 4;
            this.lozinka.Text = "Lozinka:";
            // 
            // kolnikApp
            // 
            this.kolnikApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kolnikApp.AutoSize = true;
            this.kolnikApp.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolnikApp.ForeColor = System.Drawing.Color.White;
            this.kolnikApp.Location = new System.Drawing.Point(403, 73);
            this.kolnikApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kolnikApp.Name = "kolnikApp";
            this.kolnikApp.Size = new System.Drawing.Size(199, 50);
            this.kolnikApp.TabIndex = 5;
            this.kolnikApp.Text = "KolnikApp";
            // 
            // loginGumb
            // 
            this.loginGumb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginGumb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginGumb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginGumb.Location = new System.Drawing.Point(412, 327);
            this.loginGumb.Margin = new System.Windows.Forms.Padding(4);
            this.loginGumb.Name = "loginGumb";
            this.loginGumb.Size = new System.Drawing.Size(200, 62);
            this.loginGumb.TabIndex = 2;
            this.loginGumb.Text = "Login";
            this.loginGumb.UseVisualStyleBackColor = true;
            this.loginGumb.Click += new System.EventHandler(this.loginGumb_Click);
            // 
            // loginTypeLabel
            // 
            this.loginTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTypeLabel.AutoSize = true;
            this.loginTypeLabel.Location = new System.Drawing.Point(357, 203);
            this.loginTypeLabel.Name = "loginTypeLabel";
            this.loginTypeLabel.Size = new System.Drawing.Size(181, 17);
            this.loginTypeLabel.TabIndex = 6;
            this.loginTypeLabel.TabStop = true;
            this.loginTypeLabel.Text = "Prijavi se korištenjem OIB-a";
            this.loginTypeLabel.Click += new System.EventHandler(this.loginType_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginGumb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.loginTypeLabel);
            this.Controls.Add(this.kolnikApp);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.loginGumb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(362, 470);
            this.Name = "Login";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.loginGumb, 0);
            this.Controls.SetChildIndex(this.korisnickoIme, 0);
            this.Controls.SetChildIndex(this.lozinka, 0);
            this.Controls.SetChildIndex(this.kolnikApp, 0);
            this.Controls.SetChildIndex(this.loginTypeLabel, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
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