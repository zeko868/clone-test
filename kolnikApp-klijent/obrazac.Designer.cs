﻿namespace kolnikApp_klijent
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
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.RestoreDown = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.PanelZaSadrzaj = new System.Windows.Forms.Panel();
            this.PodaciIzTablica = new System.Windows.Forms.DataGridView();
            this.Separator = new System.Windows.Forms.Label();
            this.NaslovTablice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NatragSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSlika)).BeginInit();
            this.LijeviIzbornik.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.PanelZaSadrzaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodaciIzTablica)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.Location = new System.Drawing.Point(551, 36);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(72, 31);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DeleteSlika
            // 
            this.DeleteSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSlika.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSlika.Image")));
            this.DeleteSlika.Location = new System.Drawing.Point(195, 58);
            this.DeleteSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteSlika.Name = "DeleteSlika";
            this.DeleteSlika.Size = new System.Drawing.Size(53, 49);
            this.DeleteSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteSlika.TabIndex = 10;
            this.DeleteSlika.TabStop = false;
            this.DeleteSlika.Click += new System.EventHandler(this.DeleteSlika_Click);
            this.DeleteSlika.MouseEnter += new System.EventHandler(this.DeleteSlika_MouseEnter);
            this.DeleteSlika.MouseLeave += new System.EventHandler(this.DeleteSlika_MouseLeave);
            // 
            // UpdateSlika
            // 
            this.UpdateSlika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSlika.Image = global::kolnikApp_klijent.Properties.Resources.update1;
            this.UpdateSlika.Location = new System.Drawing.Point(133, 58);
            this.UpdateSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.CreateSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.HelpSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NatragSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.LogoSlika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogoSlika.Name = "LogoSlika";
            this.LogoSlika.Size = new System.Drawing.Size(285, 132);
            this.LogoSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoSlika.TabIndex = 0;
            this.LogoSlika.TabStop = false;
            this.LogoSlika.Click += new System.EventHandler(this.LogoSlika_Click);
            this.LogoSlika.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
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
            this.LijeviIzbornik.Location = new System.Drawing.Point(0, 0);
            this.LijeviIzbornik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LijeviIzbornik.Name = "LijeviIzbornik";
            this.LijeviIzbornik.Size = new System.Drawing.Size(285, 672);
            this.LijeviIzbornik.TabIndex = 12;
            this.LijeviIzbornik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LijeviIzbornik_MouseClick);
            this.LijeviIzbornik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LijeviIzbornik_MouseDown);
            // 
            // MeniPanel
            // 
            this.MeniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MeniPanel.Location = new System.Drawing.Point(0, 143);
            this.MeniPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MeniPanel.Name = "MeniPanel";
            this.MeniPanel.Size = new System.Drawing.Size(285, 529);
            this.MeniPanel.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Header.Controls.Add(this.ImeKorisnika);
            this.Header.Controls.Add(this.Minimize);
            this.Header.Controls.Add(this.RestoreDown);
            this.Header.Controls.Add(this.closeButton);
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
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(285, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(752, 132);
            this.Header.TabIndex = 13;
            this.Header.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Header_MouseClick);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImeKorisnika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImeKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImeKorisnika.ForeColor = System.Drawing.Color.White;
            this.ImeKorisnika.Location = new System.Drawing.Point(420, 9);
            this.ImeKorisnika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Size = new System.Drawing.Size(200, 20);
            this.ImeKorisnika.TabIndex = 14;
            this.ImeKorisnika.Text = "Korisnik";
            this.ImeKorisnika.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ImeKorisnika.Click += new System.EventHandler(this.ImeKorisnika_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(632, 4);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(33, 31);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 13;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("RestoreDown.Image")));
            this.RestoreDown.Location = new System.Drawing.Point(673, 4);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestoreDown.Name = "RestoreDown";
            this.RestoreDown.Size = new System.Drawing.Size(33, 31);
            this.RestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreDown.TabIndex = 12;
            this.RestoreDown.TabStop = false;
            this.RestoreDown.Click += new System.EventHandler(this.RestoreDown_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(715, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 31);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 11;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // PanelZaSadrzaj
            // 
            this.PanelZaSadrzaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelZaSadrzaj.BackColor = System.Drawing.Color.LightSlateGray;
            this.PanelZaSadrzaj.Controls.Add(this.PodaciIzTablica);
            this.PanelZaSadrzaj.Controls.Add(this.Separator);
            this.PanelZaSadrzaj.Controls.Add(this.NaslovTablice);
            this.PanelZaSadrzaj.Location = new System.Drawing.Point(297, 143);
            this.PanelZaSadrzaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelZaSadrzaj.Name = "PanelZaSadrzaj";
            this.PanelZaSadrzaj.Size = new System.Drawing.Size(724, 514);
            this.PanelZaSadrzaj.TabIndex = 5;
            // 
            // PodaciIzTablica
            // 
            this.PodaciIzTablica.AllowUserToAddRows = false;
            this.PodaciIzTablica.AllowUserToDeleteRows = false;
            this.PodaciIzTablica.AllowUserToResizeRows = false;
            this.PodaciIzTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PodaciIzTablica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodaciIzTablica.Location = new System.Drawing.Point(0, 0);
            this.PodaciIzTablica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PodaciIzTablica.MultiSelect = false;
            this.PodaciIzTablica.Name = "PodaciIzTablica";
            this.PodaciIzTablica.ReadOnly = true;
            this.PodaciIzTablica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PodaciIzTablica.Size = new System.Drawing.Size(724, 514);
            this.PodaciIzTablica.TabIndex = 4;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KolnikAppHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "obrazac";
            this.KolnikAppHelp.SetShowHelp(this, true);
            this.Text = "obrazac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.obrazac_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obrazac_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obrazac_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NatragSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSlika)).EndInit();
            this.LijeviIzbornik.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.PanelZaSadrzaj.ResumeLayout(false);
            this.PanelZaSadrzaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodaciIzTablica)).EndInit();
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
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox RestoreDown;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label ImeKorisnika;
        private System.Windows.Forms.Panel MeniPanel;
        private System.Windows.Forms.Panel PanelZaSadrzaj;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Label NaslovTablice;
        private System.Windows.Forms.DataGridView PodaciIzTablica;
    }
}