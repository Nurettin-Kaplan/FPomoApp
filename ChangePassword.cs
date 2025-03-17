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
    public partial class ChangePassword : UserControl
    {
        private LoginForm mainForm;

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
                // burada şifre yenileme işlemini yapılacak.
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new LoginPanel(mainForm));
        }
    }
}
