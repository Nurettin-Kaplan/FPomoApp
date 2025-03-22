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
using Microsoft.VisualBasic.ApplicationServices;

namespace FPomoApp
{
    public partial class ChangePassword : UserControl
    {
        private LoginForm mainForm;
        private LoginPanel loginPanel;

        public ChangePassword(LoginForm form)
        {
            InitializeComponent();
            mainForm = form;
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

        private void PBoxViewPass2_Click(object sender, EventArgs e)
        {
            if (TxtPassword2.PasswordChar == '•')
            {
                TxtPassword2.PasswordChar = '\0'; // Normal metin olarak görünsün
                PBoxViewPass2.Image = Properties.Resources.eye; // Görüntü değişimi
            }
            else
            {
                TxtPassword2.PasswordChar = '•'; // Yıldızlı görünüm
                PBoxViewPass2.Image = Properties.Resources.eyeclose; // Görüntü değişimi
            }
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            if (TxtPassword.Text != TxtPassword2.Text)
            {
                LblStatus.Text = "Girilen şifreler eşleşmiyor.";
                TxtPassword.Clear();
                TxtPassword2.Clear();
                TxtPassword.Focus();
            }
            else
            {
                UpdatePassword();
                loginPanel = new LoginPanel(mainForm);
                MessageBox.Show("Şifreniz başarıyla değiştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.LoadUserControl(loginPanel);
            }
        }

        private void UpdatePassword()
        {
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            string query = "UPDATE TblUsers SET Password = @newPassword WHERE UserID = @userID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // SqlCommand ile sorgu oluşturuluyor
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri ekliyoruz
                        cmd.Parameters.AddWithValue("@newPassword", TxtPassword.Text); // Yeni şifre
                        cmd.Parameters.AddWithValue("@userID", Properties.Settings.Default.SavedUserID); // Kullanıcı ID'si
                        con.Open();
                        cmd.ExecuteNonQuery();

                        SessionManager.Logout();  // Kullanıcıyı oturumdan çıkart
                        Properties.Settings.Default.SavedUserID = -1; // Kullanıcı ID sil
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();  // Kullanıcıyı oturumdan çıkart
            Properties.Settings.Default.SavedUserID = -1; // Kullanıcı ID sil
            Properties.Settings.Default.Save();

            mainForm.LoadUserControl(new LoginPanel(mainForm));
        }
    }
}

