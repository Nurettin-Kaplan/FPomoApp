using System.Threading.Tasks;

namespace FPomoApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private Point _mouseDownLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownLocation = e.Location; // Fare t�klama konumunu kaydet
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Fare hareketi ile formu ta��
                this.Location = new Point(
                    this.Left + (e.X - _mouseDownLocation.X),
                    this.Top + (e.Y - _mouseDownLocation.Y)
                );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // S�r�klemeyi sonland�rmak i�in herhangi bir �ey yapmam�za gerek yok
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulaman�n kapanmas�n� sa�lar
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            if (BtnTasks.Tag.ToString() == "taskno")
            {
                BtnTasks.BackgroundImage = Properties.Resources.task;
                BtnTasks.Tag = "task";
            }
            else
            {
                BtnTasks.BackgroundImage = Properties.Resources.taskno;
                BtnTasks.Tag = "taskno";
            }
            
        }

        private void App_Load(object sender, EventArgs e)
        {
            // task butonunun image k�sm�n� de�i�tirmek i�in yap�lan
            BtnTasks.BackgroundImage = Properties.Resources.taskno;
            BtnTasks.Tag = "taskno"; // Hangi resmin kullan�ld���n� takip etmek i�in
        }
    }
}