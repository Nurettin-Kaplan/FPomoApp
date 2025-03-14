using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            mainForm.LoadUserControl(new SigninPanel(mainForm));
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
    }
}
