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
    }
}
