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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FPomoApp
{
    public partial class RefPasswordPanel : UserControl
    {
        private LoginForm mainForm;
        public RefPasswordPanel(LoginForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new LoginPanel(mainForm));
        }

        private void RefPasswordPanel_Load(object sender, EventArgs e)
        {
            TxtUsername.Focus();
        }
        private int CheckValues(string name, string mail, string phone)
        {
            if (name == "" || mail == "" || phone == "")
            {
                LblStatus.Text = "Gereken bilgileri kontrol edin.";
                return 0;
            }
            else if (!EmailValidator.IsValidEmail(mail))
            {
                LblStatus.Text = "Geçersiz e-posta adresi girdiniz.";
                TxtEmail.Text = "";
                TxtEmail.Focus();
                return 0;
            }
            return 1;
        }

        private async void BtnVerify_Click(object sender, EventArgs e)
        {
            int result = 0;
            result += CheckValues(TxtUsername.Text, TxtEmail.Text, MTxtPhone.Text);

            if(result == 1)
            {
                string connectionString = "Server=localhost; Database=FPomoDB; Integrated Security=True;";
                string query = "select UserName, Mail, Phone from TblUsers WHERE UserName=@username AND Mail=@email AND Phone=@phone";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                        cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", MTxtPhone.Text);

                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows) // Eğer veri yoksa
                            {
                                LblStatus.Text = "Eşleşen kullanıcı bulunamadı.";
                                TxtUsername.Clear();
                                TxtEmail.Clear();
                                MTxtPhone.Clear();
                                TxtUsername.Focus();
                            }
                            else
                            {
                                var emailPanel = new EmailConfirmationPanel(mainForm, TxtEmail.Text);
                                mainForm.LoadUserControl(emailPanel); // eposta onay ekranı
                                result += await emailPanel.WaitForEmailConfirmation();
                                if (result == 2)
                                {
                                    // burada bir nevi hesaba giriş yapılmış olacak
                                    // bu sebepten dolayı bir user classından bize bir nesne gerekebilir.
                                    mainForm.LoadUserControl(new ChangePassword(mainForm)); // ŞİFRE YENİLEME PANELİNİ AÇ
                                }
                                else
                                {
                                    mainForm.LoadUserControl(new RefPasswordPanel(mainForm));
                                    LblStatus.Text = "Email doğrulama başarısız.";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
