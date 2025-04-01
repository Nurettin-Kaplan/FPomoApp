using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FPomoApp
{
    public partial class TimerPanel : UserControl
    {
        public TimerPanel()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PBar.Value < PBar.Maximum)
            {
                PBar.Value += 1;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
