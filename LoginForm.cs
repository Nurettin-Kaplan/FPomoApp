using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            LoadUserControl(new LoginPanel(this));
        }

        private Point _mouseDownLocation;

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
        private User GetUserByID(int userID)
        {
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            string query = "SELECT * FROM TblUsers WHERE UserID = @userID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@userID", userID);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserID = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Password = reader.GetString(2),
                            Mail = reader.GetString(3),
                            Phone = reader.GetString(4),
                            CreatedAt = reader.GetDateTime(5),
                            Wallet = reader.GetString(6),
                        };
                    }
                }
            }
            return null;  // Kullanıcı bulunamazsa null döndür
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            int savedUserID = Properties.Settings.Default.SavedUserID;

            if (savedUserID != -1) // Eğer UserID kayıtlıysa
            {
                User user = GetUserByID(savedUserID); // Kullanıcı bilgilerini veritabanından al

                if (user != null)
                {
                    SessionManager.Login(user);
                    this.Close();
                }
            }

        }
        public void LoadUserControl(UserControl uc)
        {
            PanelContainer2.Controls.Clear(); // Önceki UserControl’ü temizle
            uc.Dock = DockStyle.Fill; // Tam boyutlandır
            PanelContainer2.Controls.Add(uc); // Yeni UserControl’ü ekle
        }
    }
}
