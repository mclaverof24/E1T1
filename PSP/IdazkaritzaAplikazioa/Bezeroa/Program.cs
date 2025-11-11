
using System.Text.Json;
using KlasePartekatuak;

namespace BezeroaApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Bezeroa bezeroa = JsonSerializer.Deserialize<Bezeroa>(args[0]);
            Application.Run(new BezeroenLeihoa(bezeroa));
        }
    }
}