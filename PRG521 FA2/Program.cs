namespace PRG521_FA2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainGUI());
            MessageBox.Show("Made by Salomon Jansen Pretorius (20231348) for PRG521 Formative Assessment 2 at CTU Training Solutions Gqeberha\n\nPress OK to exit.");
        }
    }
}
