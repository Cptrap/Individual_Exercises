using Microsoft.Extensions.DependencyInjection;
using Session_014.EF.Repositories;
using Session_14.Model;

namespace Session_14
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
            Application.Run(new CarServiceCenterForm());
        }
    }
}