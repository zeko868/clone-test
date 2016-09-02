﻿using kolnikApp_komponente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolnikApp_klijent
{
    public abstract class ApstraktnaForma : Form
    {
        static protected CommunicationHandler sockObj = null;
        protected Panel controlBox;
        protected PictureBox Minimize;
        protected PictureBox RestoreDown;
        protected PictureBox CloseButton;
        private bool isMaximized;
        private Rectangle dimensionsBeforeMaximizing;
        protected ApstraktnaForma()
        {
            InitializeComponent();
        }

        protected ApstraktnaForma(CommunicationHandler sockObj)
        {
            if (ApstraktnaForma.sockObj == null)
            {
                ApstraktnaForma.sockObj = sockObj;
            }
            InitializeComponent();
        }

        private void FormHasBeenActivated(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
            if (isMaximized)
            {
                this.MaximizeWindow();
            }
        }

        public void MaximizeWindow()
        {
            this.SetDesktopLocation(0, 0);
            this.Height = this.MaximumSize.Height;
            this.Width = this.MaximumSize.Width;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApstraktnaForma));
            this.controlBox = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.RestoreDown = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.controlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.Minimize);
            this.controlBox.Controls.Add(this.RestoreDown);
            this.controlBox.Controls.Add(this.CloseButton);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox.Location = new System.Drawing.Point(0, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(282, 33);
            this.controlBox.TabIndex = 17;
            this.controlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(162, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(33, 31);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 19;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // RestoreDown
            // 
            this.RestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoreDown.Image = ((System.Drawing.Image)(resources.GetObject("RestoreDown.Image")));
            this.RestoreDown.Location = new System.Drawing.Point(203, 0);
            this.RestoreDown.Margin = new System.Windows.Forms.Padding(4);
            this.RestoreDown.Name = "RestoreDown";
            this.RestoreDown.Size = new System.Drawing.Size(33, 31);
            this.RestoreDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreDown.TabIndex = 18;
            this.RestoreDown.TabStop = false;
            this.RestoreDown.Click += new System.EventHandler(this.RestoreDown_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(245, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 31);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 17;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ApstraktnaForma
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.controlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApstraktnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ApstraktnaForma_Load);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        //zatvaranje aplikacije klikom na "X"
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //minimiziranje aplikacije klikom na "_"
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //stavljanje aplikacije u "window" mode
        private void RestoreDown_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.SetDesktopLocation(dimensionsBeforeMaximizing.Left, dimensionsBeforeMaximizing.Top);
                this.Height = dimensionsBeforeMaximizing.Height;
                this.Width = dimensionsBeforeMaximizing.Width;
            }
            else
            {
                dimensionsBeforeMaximizing.Location = new Point(this.DesktopLocation.X, this.DesktopLocation.Y);
                dimensionsBeforeMaximizing.Size = new Size(this.Width, this.Height);
                this.MaximizeWindow();
            }
            isMaximized = !isMaximized;
        }

        //Maknuli smo border pa omogućujemo micanje aplikacije
        //detaljnije komentirati!!!!!!!!!!!!!
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        //omogućavanje micanje forme po ekranu ako smo pozicionirani na formi
        //i držimo pritisnutu tipku miša 
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMaximized)
                {
                    RestoreDown_Click(sender, e);
                    float asd = ((float)Cursor.Position.X) / Screen.FromControl(this).WorkingArea.Width;
                    this.Location = new Point((int)(Cursor.Position.X - this.Width * asd), Cursor.Position.Y);
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                if (Cursor.Position.Y == 0)
                {
                    RestoreDown_Click(sender, e);
                }
            }
        }

        private void ApstraktnaForma_Load(object sender, EventArgs e)
        {
            isMaximized = false;
            this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
        }
    }
}
