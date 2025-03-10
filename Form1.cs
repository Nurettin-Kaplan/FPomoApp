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
            _mouseDownLocation = e.Location; // Fare týklama konumunu kaydet
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Fare hareketi ile formu taþý
                this.Location = new Point(
                    this.Left + (e.X - _mouseDownLocation.X),
                    this.Top + (e.Y - _mouseDownLocation.Y)
                );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Sürüklemeyi sonlandýrmak için herhangi bir þey yapmamýza gerek yok
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamanýn kapanmasýný saðlar
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
            // task butonunun image kýsmýný deðiþtirmek için yapýlan
            BtnTasks.BackgroundImage = Properties.Resources.taskno;
            BtnTasks.Tag = "taskno"; // Hangi resmin kullanýldýðýný takip etmek için
        }
    }
}