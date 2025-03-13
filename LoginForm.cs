using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPomoApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private Point _mouseDownLocation;
        private string configFilePath = Path.Combine(Application.StartupPath, "config.txt");
        private Dictionary<string, string> configValues = new Dictionary<string, string>();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location; // Fare tıklama konumunu kaydet
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Fare hareketi ile formu taşı
                this.Location = new Point(
                    this.Left + (e.X - _mouseDownLocation.X),
                    this.Top + (e.Y - _mouseDownLocation.Y)
                );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Sürüklemeyi sonlandırmak için herhangi bir şey yapmamıza gerek yok
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamanın kapanmasını sağlar
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

            // Temayı uygula ve kaydet
            ApplyTheme(newTheme);
            SaveConfig();

            // CONFİG TEMA GÜNCELLEMESİ BURADA YAPILACAK
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ReadConfig();
            ApplyTheme(configValues["Theme"]);
            PBoxLogo.Image = Properties.Resources.logo2;    // CONFİG DOSYASI İLE TEMA KONTROLÜ BURADA YAPILACAK.
            PBoxLogo.Tag = "logo2";
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
                MessageBox.Show("Ayarlar okunurken hata oluştu: " + ex.Message);
            }

            // Eğer dosyada eksik parametre varsa varsayılanları ekle
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

        private void SaveConfig()
        {
            try
            {
                File.WriteAllLines(configFilePath, configValues.Select(kv => kv.Key + "=" + kv.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar kaydedilirken hata oluştu: " + ex.Message);
            }
        }
    }
}
