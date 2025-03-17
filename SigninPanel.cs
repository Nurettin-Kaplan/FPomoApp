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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                MessageBox.Show("Girilen bilgiler eksiktir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else if (!EmailValidator.IsValidEmail(mail))
            {
                MessageBox.Show("Geçersiz e-posta adresi girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else if (pass1 != pass2)
            {
                MessageBox.Show("Girilen şifreler eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return 1;
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
            
            if(result == 1)
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

                            LblSucces.Text = "Kayıt başarıyla tamamlandı.";
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
            else
            {
                MessageBox.Show("Kayıt olma işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
