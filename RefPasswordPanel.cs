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
    }
}
