using Npgsql;
namespace koneksi_database_winform
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
            string connStr = "Host=localhost;Username=postgres;Password=123;Database=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            conn.Open();
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainScreen());
            Application.Run(new MainScreen(conn));
            conn.Close();
        }
    }
}