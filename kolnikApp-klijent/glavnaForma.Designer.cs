namespace kolnikApp_klijent
{
    partial class glavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavnaForma));
            this.loadingTraka = new System.Windows.Forms.ProgressBar();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            // loadingTraka
            // 
            this.loadingTraka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingTraka.Location = new System.Drawing.Point(121, 382);
            this.loadingTraka.Margin = new System.Windows.Forms.Padding(4);
            this.loadingTraka.Maximum = 15;
            this.loadingTraka.Name = "loadingTraka";
            this.loadingTraka.Size = new System.Drawing.Size(824, 14);
            this.loadingTraka.Step = 1;
            this.loadingTraka.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingTraka.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(291, 71);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(511, 268);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // glavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.loadingTraka);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(505, 406);
            this.Name = "glavnaForma";
            this.Text = "KolnikApp";
            this.Controls.SetChildIndex(this.loadingTraka, 0);
            this.Controls.SetChildIndex(this.logo, 0);
            this.Controls.SetChildIndex(this.controlBox, 0);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar loadingTraka;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timerLoading;
    }
}

