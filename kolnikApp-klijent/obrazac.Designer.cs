namespace kolnikApp_klijent
{
    partial class obrazac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(obrazac));
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DeleteSlika = new System.Windows.Forms.PictureBox();
            this.UpdateSlika = new System.Windows.Forms.PictureBox();
            this.CreateSlika = new System.Windows.Forms.PictureBox();
            this.HelpSlika = new System.Windows.Forms.PictureBox();
            this.NatragSlika = new System.Windows.Forms.PictureBox();
            this.LogoSlika = new System.Windows.Forms.PictureBox();
            this.KolnikAppHelp = new System.Windows.Forms.HelpProvider();
            this.LabelaPocetna = new System.Windows.Forms.Label();
            this.LabelaNovi = new System.Windows.Forms.Label();
            this.LabelaUpdate = new System.Windows.Forms.Label();
            this.LabelaIzbrisi = new System.Windows.Forms.Label();
            this.LabelaPomoc = new System.Windows.Forms.Label();
            this.LijeviIzbornik = new System.Windows.Forms.Panel();
            this.MeniPanel = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.ImeKorisnika = new System.Windows.Forms.Label();
            this.PanelZaSadrzaj = new System.Windows.Forms.Panel();
            this.mainDgvObj = new System.Windows.Forms.DataGridView();
            this.Separator = new System.Windows.Forms.Label();
            this.NaslovTablice = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NatragSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSlika)).BeginInit();
            this.LijeviIzbornik.SuspendLayout();
            this.Header.SuspendLayout();
            this.PanelZaSadrzaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDgvObj)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.ImeKorisnika);
            this.controlBox.Size = new System.Drawing.Size(748, 33);
            this.controlBox.Controls.SetChildIndex(this.CloseButton, 0);
            this.controlBox.Controls.SetChildIndex(this.RestoreDown, 0);
            this.controlBox.Controls.SetChildIndex(this.Minimize, 0);
            this.controlBox.Controls.SetChildIndex(this.ImeKorisnika, 0);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(628, 0);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Location = new System.Drawing.Point(669, 0);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(711, 0);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Location = new System.Drawing.Point(547, 36);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(72, 31);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            this.LogoutButton.Leave += new System.EventHandler(this.LogoutButton_Leave);
            // 
            // DeleteSlika
            // 
            this.DeleteSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSlika.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSlika.Image")));
            this.DeleteSlika.Location = new System.Drawing.Point(195, 58);
            this.DeleteSlika.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSlika.Name = "DeleteSlika";
            this.DeleteSlika.Size = new System.Drawing.Size(53, 49);
            this.DeleteSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteSlika.TabIndex = 10;
            this.DeleteSlika.TabStop = false;
            this.DeleteSlika.MouseEnter += new System.EventHandler(this.DeleteSlika_MouseEnter);
            this.DeleteSlika.MouseLeave += new System.EventHandler(this.DeleteSlika_MouseLeave);
            // 
            // UpdateSlika
            // 
            this.UpdateSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSlika.Image = global::kolnikApp_klijent.Properties.Resources.update1;
            this.UpdateSlika.Location = new System.Drawing.Point(133, 58);
            this.UpdateSlika.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateSlika.Name = "UpdateSlika";
            this.UpdateSlika.Size = new System.Drawing.Size(53, 49);
            this.UpdateSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateSlika.TabIndex = 9;
            this.UpdateSlika.TabStop = false;
            this.UpdateSlika.Click += new System.EventHandler(this.UpdateSlika_Click);
            this.UpdateSlika.MouseEnter += new System.EventHandler(this.UpdateSlika_MouseEnter);
            this.UpdateSlika.MouseLeave += new System.EventHandler(this.UpdateSlika_MouseLeave);
            // 
            // CreateSlika
            // 
            this.CreateSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateSlika.Image = global::kolnikApp_klijent.Properties.Resources.add;
            this.CreateSlika.Location = new System.Drawing.Point(72, 58);
            this.CreateSlika.Margin = new System.Windows.Forms.Padding(4);
            this.CreateSlika.Name = "CreateSlika";
            this.CreateSlika.Size = new System.Drawing.Size(53, 49);
            this.CreateSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateSlika.TabIndex = 8;
            this.CreateSlika.TabStop = false;
            this.CreateSlika.Click += new System.EventHandler(this.CreateSlika_Click);
            this.CreateSlika.MouseEnter += new System.EventHandler(this.CreateSlika_MouseEnter);
            this.CreateSlika.MouseLeave += new System.EventHandler(this.CreateSlika_MouseLeave);
            // 
            // HelpSlika
            // 
            this.HelpSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpSlika.Image = global::kolnikApp_klijent.Properties.Resources.info;
            this.HelpSlika.Location = new System.Drawing.Point(256, 58);
            this.HelpSlika.Margin = new System.Windows.Forms.Padding(4);
            this.HelpSlika.Name = "HelpSlika";
            this.HelpSlika.Size = new System.Drawing.Size(53, 49);
            this.HelpSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpSlika.TabIndex = 3;
            this.HelpSlika.TabStop = false;
            this.HelpSlika.Click += new System.EventHandler(this.HelpSlika_Click);
            this.HelpSlika.MouseEnter += new System.EventHandler(this.HelpSlika_MouseEnter);
            this.HelpSlika.MouseLeave += new System.EventHandler(this.HelpSlika_MouseLeave);
            // 
            // NatragSlika
            // 
            this.NatragSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NatragSlika.Image = global::kolnikApp_klijent.Properties.Resources.back;
            this.NatragSlika.Location = new System.Drawing.Point(11, 58);
            this.NatragSlika.Margin = new System.Windows.Forms.Padding(4);
            this.NatragSlika.Name = "NatragSlika";
            this.NatragSlika.Size = new System.Drawing.Size(53, 49);
            this.NatragSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NatragSlika.TabIndex = 1;
            this.NatragSlika.TabStop = false;
            this.NatragSlika.Click += new System.EventHandler(this.NatragSlika_Click);
            this.NatragSlika.MouseEnter += new System.EventHandler(this.HomeSlika_MouseEnter);
            this.NatragSlika.MouseLeave += new System.EventHandler(this.HomeSlika_MouseLeave);
            // 
            // LogoSlika
            // 
            this.LogoSlika.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoSlika.Image = ((System.Drawing.Image)(resources.GetObject("LogoSlika.Image")));
            this.LogoSlika.Location = new System.Drawing.Point(0, 0);
            this.LogoSlika.Margin = new System.Windows.Forms.Padding(4);
            this.LogoSlika.Name = "LogoSlika";
            this.LogoSlika.Size = new System.Drawing.Size(285, 132);
            this.LogoSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoSlika.TabIndex = 0;
            this.LogoSlika.TabStop = false;
            // 
            // KolnikAppHelp
            // 
            this.KolnikAppHelp.HelpNamespace = "KolnikAppHelp.chm";
            // 
            // LabelaPocetna
            // 
            this.LabelaPocetna.AutoSize = true;
            this.LabelaPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelaPocetna.Location = new System.Drawing.Point(8, 113);
            this.LabelaPocetna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaPocetna.Name = "LabelaPocetna";
            this.LabelaPocetna.Size = new System.Drawing.Size(51, 17);
            this.LabelaPocetna.TabIndex = 0;
            this.LabelaPocetna.Text = "Natrag";
            this.LabelaPocetna.Visible = false;
            // 
            // LabelaNovi
            // 
            this.LabelaNovi.AutoSize = true;
            this.LabelaNovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelaNovi.Location = new System.Drawing.Point(87, 113);
            this.LabelaNovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaNovi.Name = "LabelaNovi";
            this.LabelaNovi.Size = new System.Drawing.Size(36, 17);
            this.LabelaNovi.TabIndex = 2;
            this.LabelaNovi.Text = "Novi";
            this.LabelaNovi.Visible = false;
            // 
            // LabelaUpdate
            // 
            this.LabelaUpdate.AutoSize = true;
            this.LabelaUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelaUpdate.Location = new System.Drawing.Point(133, 113);
            this.LabelaUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaUpdate.Name = "LabelaUpdate";
            this.LabelaUpdate.Size = new System.Drawing.Size(54, 17);
            this.LabelaUpdate.TabIndex = 3;
            this.LabelaUpdate.Text = "Update";
            this.LabelaUpdate.Visible = false;
            // 
            // LabelaIzbrisi
            // 
            this.LabelaIzbrisi.AutoSize = true;
            this.LabelaIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelaIzbrisi.Location = new System.Drawing.Point(204, 113);
            this.LabelaIzbrisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaIzbrisi.Name = "LabelaIzbrisi";
            this.LabelaIzbrisi.Size = new System.Drawing.Size(44, 17);
            this.LabelaIzbrisi.TabIndex = 4;
            this.LabelaIzbrisi.Text = "Izbriši";
            this.LabelaIzbrisi.Visible = false;
            // 
            // LabelaPomoc
            // 
            this.LabelaPomoc.AutoSize = true;
            this.LabelaPomoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelaPomoc.Location = new System.Drawing.Point(256, 113);
            this.LabelaPomoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelaPomoc.Name = "LabelaPomoc";
            this.LabelaPomoc.Size = new System.Drawing.Size(81, 17);
            this.LabelaPomoc.TabIndex = 5;
            this.LabelaPomoc.Text = "Pomoć (F1)";
            this.LabelaPomoc.Visible = false;
            // 
            // LijeviIzbornik
            // 
            this.LijeviIzbornik.Controls.Add(this.MeniPanel);
            this.LijeviIzbornik.Controls.Add(this.LogoSlika);
            this.LijeviIzbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.LijeviIzbornik.Location = new System.Drawing.Point(2, 2);
            this.LijeviIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.LijeviIzbornik.Name = "LijeviIzbornik";
            this.LijeviIzbornik.Size = new System.Drawing.Size(285, 668);
            this.LijeviIzbornik.TabIndex = 12;
            // 
            // MeniPanel
            // 
            this.MeniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MeniPanel.Location = new System.Drawing.Point(0, 143);
            this.MeniPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MeniPanel.Name = "MeniPanel";
            this.MeniPanel.Size = new System.Drawing.Size(285, 492);
            this.MeniPanel.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Header.Controls.Add(this.LogoutButton);
            this.Header.Controls.Add(this.NatragSlika);
            this.Header.Controls.Add(this.LabelaPomoc);
            this.Header.Controls.Add(this.HelpSlika);
            this.Header.Controls.Add(this.LabelaIzbrisi);
            this.Header.Controls.Add(this.LabelaPocetna);
            this.Header.Controls.Add(this.DeleteSlika);
            this.Header.Controls.Add(this.CreateSlika);
            this.Header.Controls.Add(this.LabelaUpdate);
            this.Header.Controls.Add(this.LabelaNovi);
            this.Header.Controls.Add(this.UpdateSlika);
            this.Header.Controls.Add(this.controlBox);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(287, 2);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(748, 132);
            this.Header.TabIndex = 13;
            this.Header.Controls.SetChildIndex(this.controlBox, 0);
            this.Header.Controls.SetChildIndex(this.UpdateSlika, 0);
            this.Header.Controls.SetChildIndex(this.LabelaNovi, 0);
            this.Header.Controls.SetChildIndex(this.LabelaUpdate, 0);
            this.Header.Controls.SetChildIndex(this.CreateSlika, 0);
            this.Header.Controls.SetChildIndex(this.DeleteSlika, 0);
            this.Header.Controls.SetChildIndex(this.LabelaPocetna, 0);
            this.Header.Controls.SetChildIndex(this.LabelaIzbrisi, 0);
            this.Header.Controls.SetChildIndex(this.HelpSlika, 0);
            this.Header.Controls.SetChildIndex(this.LabelaPomoc, 0);
            this.Header.Controls.SetChildIndex(this.NatragSlika, 0);
            this.Header.Controls.SetChildIndex(this.LogoutButton, 0);
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImeKorisnika.AutoSize = true;
            this.ImeKorisnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeKorisnika.ForeColor = System.Drawing.Color.White;
            this.ImeKorisnika.Location = new System.Drawing.Point(547, 9);
            this.ImeKorisnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Size = new System.Drawing.Size(69, 20);
            this.ImeKorisnika.TabIndex = 14;
            this.ImeKorisnika.Text = "Korisnik";
            this.ImeKorisnika.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ImeKorisnika.Click += new System.EventHandler(this.ImeKorisnika_Click);
            this.ImeKorisnika.Resize += new System.EventHandler(this.ImeKorisnika_Resize);
            // 
            // PanelZaSadrzaj
            // 
            this.PanelZaSadrzaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelZaSadrzaj.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanelZaSadrzaj.Controls.Add(this.mainDgvObj);
            this.PanelZaSadrzaj.Controls.Add(this.Separator);
            this.PanelZaSadrzaj.Controls.Add(this.NaslovTablice);
            this.PanelZaSadrzaj.Location = new System.Drawing.Point(297, 143);
            this.PanelZaSadrzaj.Margin = new System.Windows.Forms.Padding(4);
            this.PanelZaSadrzaj.Name = "PanelZaSadrzaj";
            this.PanelZaSadrzaj.Size = new System.Drawing.Size(724, 514);
            this.PanelZaSadrzaj.TabIndex = 5;
            // 
            // mainDgvObj
            // 
            this.mainDgvObj.AllowUserToAddRows = false;
            this.mainDgvObj.AllowUserToDeleteRows = false;
            this.mainDgvObj.AllowUserToResizeRows = false;
            this.mainDgvObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDgvObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDgvObj.Location = new System.Drawing.Point(0, 0);
            this.mainDgvObj.Margin = new System.Windows.Forms.Padding(4);
            this.mainDgvObj.MultiSelect = false;
            this.mainDgvObj.Name = "mainDgvObj";
            this.mainDgvObj.ReadOnly = true;
            this.mainDgvObj.RowHeadersVisible = false;
            this.mainDgvObj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDgvObj.Size = new System.Drawing.Size(724, 514);
            this.mainDgvObj.TabIndex = 4;
            //this.mainDgvObj.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.PodaciIzTablica_ColumnWidthChanged);
            this.mainDgvObj.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PodaciIzTablica_RowEnter);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Black;
            this.Separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separator.Location = new System.Drawing.Point(7, 59);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(713, 2);
            this.Separator.TabIndex = 3;
            // 
            // NaslovTablice
            // 
            this.NaslovTablice.AutoSize = true;
            this.NaslovTablice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NaslovTablice.ForeColor = System.Drawing.Color.White;
            this.NaslovTablice.Location = new System.Drawing.Point(4, 11);
            this.NaslovTablice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaslovTablice.Name = "NaslovTablice";
            this.NaslovTablice.Size = new System.Drawing.Size(188, 36);
            this.NaslovTablice.TabIndex = 2;
            this.NaslovTablice.Text = "Dobro došli!";
            // 
            // obrazac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1037, 672);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LijeviIzbornik);
            this.Controls.Add(this.PanelZaSadrzaj);
            this.KolnikAppHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.MinimumSize = new System.Drawing.Size(741, 442);
            this.Name = "obrazac";
            this.KolnikAppHelp.SetShowHelp(this, true);
            this.Text = "obrazac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.obrazac_FormClosing);
            this.Load += new System.EventHandler(this.obrazac_Load);
            this.Resize += new System.EventHandler(this.obrazac_Resize);
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NatragSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSlika)).EndInit();
            this.LijeviIzbornik.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.PanelZaSadrzaj.ResumeLayout(false);
            this.PanelZaSadrzaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDgvObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoSlika;
        private System.Windows.Forms.PictureBox NatragSlika;
        private System.Windows.Forms.PictureBox HelpSlika;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.PictureBox CreateSlika;
        private System.Windows.Forms.PictureBox UpdateSlika;
        private System.Windows.Forms.PictureBox DeleteSlika;
        private System.Windows.Forms.HelpProvider KolnikAppHelp;
        private System.Windows.Forms.Label LabelaPomoc;
        private System.Windows.Forms.Label LabelaIzbrisi;
        private System.Windows.Forms.Label LabelaUpdate;
        private System.Windows.Forms.Label LabelaNovi;
        private System.Windows.Forms.Label LabelaPocetna;
        private System.Windows.Forms.Panel LijeviIzbornik;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label ImeKorisnika;
        private System.Windows.Forms.Panel MeniPanel;
        private System.Windows.Forms.Panel PanelZaSadrzaj;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Label NaslovTablice;
        private System.Windows.Forms.DataGridView mainDgvObj;
    }
}