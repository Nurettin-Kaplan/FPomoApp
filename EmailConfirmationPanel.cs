using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPomoApp
{
    public partial class EmailConfirmationPanel : UserControl
    {
        private LoginForm mainForm;
        private string email = "";
        private int remainingTime = 120; // 2 dakika = 120 saniye
        private string code = "";
        private TaskCompletionSource<int> confirmationTask; // TaskCompletionSource ile bekleme kontrolü

        public EmailConfirmationPanel(LoginForm form, string uemail)
        {
            InitializeComponent();
            mainForm = form;
            email = uemail;
            confirmationTask = new TaskCompletionSource<int>();
        }
        public Task<int> WaitForEmailConfirmation()
        {
            return confirmationTask.Task;  // Email doğrulanana kadar bekle
        }
        public string GenerateVerificationCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); // 6 haneli rastgele kod
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            code = GenerateVerificationCode();
            SendEmail(email, code);
            remainingTime = 120; // Süreyi sıfırla
            LblCountdown.Text = "02:00"; // Label'ı sıfırla
            timer1.Enabled = true; // Timer'ı başlat
        }
        public void SendEmail(string email, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("fpomoapp@gmail.com");
                mail.To.Add(email);
                mail.Subject = "E-posta Doğrulama Kodu";
                mail.Body = "Doğrulama kodunuz: " + code;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("fpomoapp@gmail.com", "ofcz zfau lfpi mwbo");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                int minutes = remainingTime / 60;
                int seconds = remainingTime % 60;

                LblCountdown.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                timer1.Enabled = false; // Timer'ı durdur
                confirmationTask.TrySetResult(0);  // Task tamamlanmadıysa 0 olarak ayarla
            }
        }
        private void BtnConfrim_Click(object sender, EventArgs e)
        {
            if (MTxtCode.Text == code)
            {
                confirmationTask.TrySetResult(1);
            }
            else
            {
                confirmationTask.TrySetResult(0);  // Task tamamlanmadıysa 0 olarak ayarla
            }
        }
    }
}
