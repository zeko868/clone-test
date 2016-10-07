using kolnikApp_komponente;
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
    /// <summary>
    /// Klasa koja je nasljeđivana od svih ostalih korištenih korisnički definiranih formi u aplikaciji čime se postiže definiranje svojstava i dizajna svih formi s jednog mjesta
    /// </summary>
    public abstract class ApstraktnaForma : Form
    {
        /// <summary>
        /// Mrežna utičnica putem koje se vrši mrežna komunikacija
        /// </summary>
        static protected CommunicationHandler sockObj = null;

        /// <summary>
        /// Okvir s kontrolama unutar kojeg se nalaze tipke za manipulaciju s formom
        /// </summary>
        protected Panel controlBox;

        /// <summary>
        /// Slika koja predstavlja tipku za minimizaciju forme
        /// </summary>
        protected PictureBox Minimize;

        /// <summary>
        /// Slika koja predstavlja tipku za maksimizaciju/normalizaciju forme
        /// </summary>
        protected PictureBox RestoreDown;

        /// <summary>
        /// Slika koja predstavlja tipku za zatvaranje forme
        /// </summary>
        protected PictureBox CloseButton;

        /// <summary>
        /// Je li trenutna forma trenutno maksimizirana (s obzirom da ne koriste klasični okviri formi iz samog Windows operacijskog sustava, maksimizacija formi kojeg pruža API OS-a ne daje prihvatljiv efekt koji bi zadovoljavao kriterij maksimiziranja nego se postiže vlastitom implementacijom
        /// </summary>
        private bool isMaximized;

        /// <summary>
        /// Je li trenutnoj formi moguće mijenjati veličinu (važi za maksimizirane forme kao i za forme koje ne sadrže kompletni okvir s kontrolama, tj. tipku za maksimizaciju/normalizaciju)
        /// </summary>
        private bool isResizable;

        /// <summary>
        /// Je li trenutno stanje forme nepromijenjeno od samog početka pojave trenutne forme
        /// </summary>
        private bool initialState;

        /// <summary>
        /// Dimenzije forme prije maksimiziranja forme (kako bi se kasnije klikom tipke za normalizaciju forma mogla poprimiti posljednje korištene dimenzije)
        /// </summary>
        private Rectangle dimensionsBeforeMaximizing;

        /// <summary>
        /// Konstruktor bazne korisnički definirane klase forme gdje se definira hoće li forme sadržavati klasičan okvir s kontrolama
        /// </summary>
        /// <param name="fullControlBox">Istina ukoliko forma treba sadržava tipke za minimizaciju, maksimizaciju/normalizaciju i zatvaranje; inače sadrži samo tipku za zatvaranje forme</param>
        protected ApstraktnaForma(bool fullControlBox = true)
        {
            InitializeComponent();
            if (!fullControlBox)
            {
                isResizable = false;
                RestoreDown.Visible = false;
                Minimize.Visible = false;
            }
        }

        /// <summary>
        /// Konstruktor bazne korisnički definirane klase forme gdje se definira mrežna utičnica putem koje će se vršiti mrežna komunikacija
        /// </summary>
        /// <param name="sockObj">Mrežna utičnica putem koje se vrši mrežna komunikacija u svim ostalim formama naslijeđenim od bazne</param>
        protected ApstraktnaForma(CommunicationHandler sockObj)
        {
            if (ApstraktnaForma.sockObj == null)
            {
                ApstraktnaForma.sockObj = sockObj;
            }
            InitializeComponent();
        }

        /// <summary>
        /// Prilagođava maksimizirani prozor zaslonu ukoliko tokom izvođenja aplikacije se promijeni rezolucija zaslona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDefinitionOfMaximizedState(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
            if (isMaximized)
            {
                this.MaximizeWindow();
            }
        }

        /// <summary>
        /// Maksimizira formu preko cijelog zaslona
        /// </summary>
        public void MaximizeWindow()
        {
            this.SetDesktopLocation(0, 0);
            this.Height = this.MaximumSize.Height;
            this.Width = this.MaximumSize.Width;
        }

        /// <summary>
        /// Definira inicijalna stilska i druga svojstva alocirane forme
        /// </summary>
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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Padding = new System.Windows.Forms.Padding(2);
            this.controlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.isMaximized = false;
            this.initialState = true;
            this.isResizable = true;

            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new System.EventHandler(this.ChangeDefinitionOfMaximizedState);
        }

        /// <summary>
        /// Zatvara prozor klikom na sliku za zatvaranje prozora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Minimizira prozor klikom na sliku za minimizaciju prozora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maksimizira ili pak normalizira prozor klikom na sliku za maksimizaciju/normalizaciju prozora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            isResizable = !isResizable;
            if (initialState)
            {
                System.Threading.Thread.Sleep(25);  //pomaže da se prilikom prvog maksimiziranja instancirane forme ne pojavi izbugirana forma koja se do sada nekada pojavljivala
                initialState = false;
            }
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

        /// <summary>
        /// Omogućuje micanje forme po ekranu ako smo pozicionirani na formi i držimo pritisnutu lijevu tipku miša jer nakon odbacivanja klasičnog okvira formi iz Windows OS-a nije moguće vršiti navedenu operaciju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMaximized)
                {
                    float horizontalRatioOfClickedPositionOnOverallTitlebar;
                    RestoreDown_Click(sender, e);
                    horizontalRatioOfClickedPositionOnOverallTitlebar = ((float)Cursor.Position.X) / Screen.FromControl(this).WorkingArea.Width;
                    this.Location = new Point((int)(Cursor.Position.X - this.Width * horizontalRatioOfClickedPositionOnOverallTitlebar), Cursor.Position.Y);
                }
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                if (Cursor.Position.Y == 0 && isResizable)
                {
                    RestoreDown_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Pohranjuje veličinu dijela zaslona koji se može iskoristiti za maksimizaciju forme nakon što se očita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApstraktnaForma_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        /// <summary>
        /// Širina granice u pikselima oko ruba prozora na kojeg je moguće kliknuti u svrhi mijenjanja veličine forme
        /// </summary>
        const int resizableBorderWidth = 10;

        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, resizableBorderWidth); } }
        new Rectangle Left { get { return new Rectangle(0, 0, resizableBorderWidth, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - resizableBorderWidth, this.ClientSize.Width, resizableBorderWidth); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - resizableBorderWidth, 0, resizableBorderWidth, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, resizableBorderWidth, resizableBorderWidth); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - resizableBorderWidth, 0, resizableBorderWidth, resizableBorderWidth); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - resizableBorderWidth, resizableBorderWidth, resizableBorderWidth); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - resizableBorderWidth, this.ClientSize.Height - resizableBorderWidth, resizableBorderWidth, resizableBorderWidth); } }


        /// <summary>
        /// Nadjačana metoda za renderiranje formi, konkretno za definiranje rubova čijim povlačenjem je moguće mijenjati veličinu forme jer nakon odbacivanja klasičnog okvira formi iz Windows OS-a nije moguće vršiti navedenu operaciju
        /// </summary>
        /// <param name="message">Poruka koja se šalje jezgri operacijskog sustava</param>
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (isResizable && message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
    }
}
