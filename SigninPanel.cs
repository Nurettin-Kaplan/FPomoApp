using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FPomoApp
{
    public partial class SigninPanel : UserControl
    {
        private LoginForm mainForm;

        public SigninPanel(LoginForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new LoginPanel(mainForm));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            TxtUsername.Focus();
        }

        private int CheckValues(string name, string pass1, string pass2, string mail, string phone)
        {
            if (name == "" || pass1 == "" || pass2 == "" || mail == "" || phone == "")
            {
                LblStatus.Text = "Girilen bilgiler eksiktir.";
                return 0;
            }
            else if (!EmailValidator.IsValidEmail(mail))
            {
                LblStatus.Text = "Geçersiz e-posta adresi girdiniz.";
                TxtEmail.Text = "";
                TxtEmail.Focus();
                return 0;
            }
            else if (pass1 != pass2)
            {
                LblStatus.Text = "Girilen şifreler eşleşmiyor.";
                TxtPassword.Text = "";
                TxtPassword2.Text = "";
                TxtPassword.Focus();
                return 0;
            }
            return 1;
        }
        // Kullanıcı adı kontrol fonksiyonu
        private bool CheckIfUsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM TblUsers WHERE UserName = @name";
            return CheckIfExists(query, username, "name");
        }
        // E-posta kontrol fonksiyonu
        private bool CheckIfEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM TblUsers WHERE Mail = @mail";
            return CheckIfExists(query, email, "mail");
        }
        // Telefon numarası kontrol fonksiyonu
        private bool CheckIfPhoneExists(string phone)
        {
            string query = "SELECT COUNT(*) FROM TblUsers WHERE Phone = @phone";
            return CheckIfExists(query, phone, "phone");
        }
        private bool CheckIfExists(string query, string value, string paramName)
        {
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@" + paramName, value);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();
                    return count > 0;
                }
            }
        }
        private async void BtnSignIn_Click(object sender, EventArgs e)
        {
            int result = 0;
            string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
            string username = TxtUsername.Text;
            string password1 = TxtPassword.Text;
            string password2 = TxtPassword2.Text;
            string email = TxtEmail.Text;
            string phone = MTxtPhone.Text;
            string query = "INSERT INTO TblUsers (UserName, Password, Mail, Phone) VALUES (@name, @pass, @mail, @phone)";

            result += CheckValues(username, password1, password2, email, phone);

            // Hangi bilgi var, sadece onu değiştir
            if (CheckIfUsernameExists(username))
            {
                LblStatus.Text = "Bu kullanıcı adı zaten var.";
                result -= 1;
            }
            else if (CheckIfEmailExists(email))
            {
                LblStatus.Text = "Bu e-posta zaten var.";
                result -= 1;
            }
            else if (CheckIfPhoneExists(phone))
            {
                LblStatus.Text = "Bu telefon numarası zaten var.";
                result -= 1;
            }

            if (result == 1)
            {
                var emailPanel = new EmailConfirmationPanel(mainForm, email);
                mainForm.LoadUserControl(emailPanel); // eposta onay ekranı
                result += await emailPanel.WaitForEmailConfirmation();
            }

            if (result == 2)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri tanımla
                        cmd.Parameters.AddWithValue("@name", username);
                        cmd.Parameters.AddWithValue("@pass", password1);
                        cmd.Parameters.AddWithValue("@mail", email);
                        cmd.Parameters.AddWithValue("@phone", phone);

                        try
                        {
                            con.Open(); // Bağlantıyı aç
                            result += cmd.ExecuteNonQuery(); // Sorguyu çalıştır
                            con.Close(); // Bağlantıyı kapat

                            LblStatus.Text = "Kayıt başarıyla tamamlandı.";
                            TxtUsername.Text = "";
                            TxtPassword.Text = "";
                            TxtPassword2.Text = "";
                            TxtEmail.Text = "";
                            MTxtPhone.Text = "";
                            TxtUsername.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
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
    }
}
