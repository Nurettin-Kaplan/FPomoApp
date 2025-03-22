namespace FPomoApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Oturum kontrolü yap
            if (SessionManager.IsLoggedIn())
            {
                // Kullanýcý zaten giriþ yapmýþ, direkt olarak AppForm aç
                Application.Run(new App());
            }
            else
            {
                // Kullanýcý giriþ yapmamýþ, LoginForm'u göster
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();  // ShowDialog() burada doðru tercih çünkü kullanýcý giriþ yapmadan baþka bir þey yapamaz

                // LoginForm kapandýktan sonra, App formunu baþlat
                if (SessionManager.IsLoggedIn())  // Giriþ baþarýlýysa
                {
                    Application.Run(new App());
                }
                else
                {
                    // Giriþ baþarýsýzsa, uygulama kapatýlabilir
                    Application.Exit();
                }
            }
        }
    }
}