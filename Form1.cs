using System.Threading.Tasks;

namespace FPomoApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private Point _mouseDownLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location; // Fare týklama konumunu kaydet
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Fare hareketi ile formu taþý
                this.Location = new Point(
                    this.Left + (e.X - _mouseDownLocation.X),
                    this.Top + (e.Y - _mouseDownLocation.Y)
                );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Sürüklemeyi sonlandýrmak için herhangi bir þey yapmamýza gerek yok
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamanýn kapanmasýný saðlar
        }

        Dictionary<Button, (Bitmap, Bitmap)> buttonPicture = new Dictionary<Button, (Bitmap, Bitmap)>();

        private void App_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Hoþ geldin, " + SessionManager.CurrentUser.UserName);
            }
            else
            {
                MessageBox.Show("Lütfen giriþ yapýn.");
                this.Close();
            }

            

            // Örnek olarak butonlarý ekleyelim ve onlarýn resimlerini tanýmlayalým
            buttonPicture.Add(BtnTasks, (Properties.Resources.task2, Properties.Resources.task1));
            buttonPicture.Add(BtnWTask, (Properties.Resources.tasklist2, Properties.Resources.tasklist1));
            buttonPicture.Add(BtnPomo, (Properties.Resources.timer1, Properties.Resources.timer2));
            buttonPicture.Add(BtnStatics, (Properties.Resources.statistics1, Properties.Resources.statistics2));
            buttonPicture.Add(BtnWallet, (Properties.Resources.wallet1, Properties.Resources.wallet2));
            buttonPicture.Add(BtnSettings, (Properties.Resources.setting1, Properties.Resources.setting2));
            buttonPicture.Add(BtnInfo, (Properties.Resources.info1, Properties.Resources.info2));

            // Tüm butonlara Click event'ini baðla
            foreach (Button btn in buttonPicture.Keys)
            {
                //btn.Click += Buton_Click;
                btn.BackgroundImage = buttonPicture[btn].Item1; // Varsayýlan resim
                btn.Tag = "first"; // Ýlk hali takip etmek için Tag ekledik
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Properties.Settings.Default.SavedUserID = -1; // Kaydý sýfýrla
            Properties.Settings.Default.Save();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear(); // Önceki UserControl’ü temizle
            uc.Dock = DockStyle.Fill; // Tam boyutlandýr
            panelContainer.Controls.Add(uc); // Yeni UserControl’ü ekle
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";

        }

        private void BtnWTask_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";

            LoadUserControl(new Tasks());
        }

        private void BtnPomo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";
        }

        private void BtnStatics_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";
        }

        private void BtnWallet_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Önce tüm butonlarý varsayýlan resmine döndür
            foreach (Button btn in buttonPicture.Keys)
            {
                btn.BackgroundImage = buttonPicture[btn].Item1; // Ýlk resme dön
                btn.Tag = "first";
            }

            // Þimdi sadece týklanan butonun resmini deðiþtir
            clickedButton.BackgroundImage = buttonPicture[clickedButton].Item2; // Ýkinci resme geç
            clickedButton.Tag = "second";
        }
    }
}