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
        private string configFilePath = Path.Combine(Application.StartupPath, "config.txt");
        private Dictionary<string, string> configValues = new Dictionary<string, string>();

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
            ReadConfig();
            ApplyTheme(configValues["Theme"]);
            PBoxLogo.Image = Properties.Resources.logo2;    // CONFÝG DOSYASI ÝLE TEMA KONTROLÜ BURADA YAPILACAK.
            PBoxLogo.Tag = "logo2";

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

        private void ReadConfig()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    var lines = File.ReadAllLines(configFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            configValues[parts[0].Trim()] = parts[1].Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar okunurken hata oluþtu: " + ex.Message);
            }

            // Eðer dosyada eksik parametre varsa varsayýlanlarý ekle
            if (!configValues.ContainsKey("Theme"))
                configValues["Theme"] = "1";
        }

        private void ApplyTheme(string theme)
        {
            if (theme == "0")
            {
                this.BackColor = Color.FromArgb(31, 31, 31);
                this.ForeColor = Color.White;
                panel1.BackColor = Color.FromArgb(31, 31, 31);
                BtnDown.BackColor = Color.FromArgb(31, 31, 31);
                BtnClose.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                panel1.BackColor = Color.White;
                BtnDown.BackColor = Color.White;
                BtnClose.BackColor = Color.White;
            }
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

        private void PBoxLogo_Click(object sender, EventArgs e)
        {
            if (PBoxLogo.Tag.ToString() == "logo2")
            {
                PBoxLogo.Image = Properties.Resources.logo1;
                PBoxLogo.Tag = "logo1";
            }
            else
            {
                PBoxLogo.Image = Properties.Resources.logo2;
                PBoxLogo.Tag = "logo2";
            }

            string newTheme = this.BackColor == Color.White ? "0" : "1";
            configValues["Theme"] = newTheme;

            // Temayý uygula ve kaydet
            ApplyTheme(newTheme);
            SaveConfig();

            // CONFÝG TEMA GÜNCELLEMESÝ BURADA YAPILACAK
        }

        private void SaveConfig()
        {
            try
            {
                File.WriteAllLines(configFilePath, configValues.Select(kv => kv.Key + "=" + kv.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar kaydedilirken hata oluþtu: " + ex.Message);
            }
        }
    }
}