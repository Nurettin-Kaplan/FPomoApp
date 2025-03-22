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
    public partial class LoginPanel : UserControl
    {
        private LoginForm mainForm;

        public LoginPanel(LoginForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        public string StatusText
        {
            get { return LblStatus.Text; }
            set { LblStatus.Text = value; }
        }
        public void ChangeLabelGreen()
        {
            LblStatus.ForeColor = Color.Green;
        }
        public void ChangeLabelRed()
        {
            LblStatus.ForeColor = Color.Red;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = ValidateUser(TxtUsername.Text, TxtPassword.Text); // Kullanıcıyı doğrula

            if (user != null)
            {
                SessionManager.Login(user);  // Kullanıcıyı oturuma kaydet

                if (CHKRememberMe.Checked)
                {
                    Properties.Settings.Default.RememberMe = CHKRememberMe.Checked;
                    Properties.Settings.Default.SavedUserID = user.UserID; // Kullanıcı ID kaydet
                    Properties.Settings.Default.Save();
                }

                mainForm.Close();
            }
            else
            {
                LblStatus.Text = "Hatalı kullanıcı adı veya şifre.";
                TxtUsername.Clear();
                TxtPassword.Clear();
                TxtUsername.Focus();
            }
        }
        private User ValidateUser(string username, string password)
        {
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            string query = "SELECT * FROM TblUsers WHERE UserName=@username AND Password=@password";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);  // Burada şifreyi hashleyerek saklamak daha güvenli olur!

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

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new SigninPanel(mainForm), "SigninPanel");
        }

        private void PBoxViewPass_Click(object sender, EventArgs e)
        {
            // PasswordBox'taki metni görünür yapmak
            if (TxtPassword.PasswordChar == '•')
            {
                TxtPassword.PasswordChar = '\0'; // Normal metin olarak görünsün
                PBoxViewPass.Image = Properties.Resources.eye; // Görüntü değişimi
            }
            else
            {
                TxtPassword.PasswordChar = '•'; // Yıldızlı görünüm
                PBoxViewPass.Image = Properties.Resources.eyeclose; // Görüntü değişimi
            }
        }

        private void LinkLblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.LoadUserControl(new RefPasswordPanel(mainForm), "RefPasswordPanel");
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            TxtUsername.Focus();
        }

        private void CHKRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (!CHKRememberMe.Checked)  // Eğer kutu kaldırıldıysa
            {
                Properties.Settings.Default.SavedUserID = -1; // Kaydı temizle
                Properties.Settings.Default.Save();
            }
        }
    }
}
