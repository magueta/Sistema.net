using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SVPresentacion
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
            var host=CreateHostBuilder().Build();
            Application.Run(new Form1());
        }
        /// <summary>
        /// Enlaza el config con el archivo appsettings.json, para tomar los valore internos de este de forma timereal
        /// </summary>
        /// <returns>
        /// IHostBuilder 
        /// </returns>
        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((contextm,config) => {
                config.AddJsonFile("appsettings.json", optional:false,reloadOnChange:true);
            });
        

    }
}