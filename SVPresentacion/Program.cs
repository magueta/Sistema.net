using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SVContenedor;
using SVContenedor.Implementacion;
using SVContenedor.Interfaces;
using SVPresentacion.Formularios;
using SVServicios;
using SVServicios.Implementacion;
using SVServicios.Interfaces;

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
            var formServicios = host.Services.GetRequiredService<frmProducto>();

            Application.Run(formServicios);
        }
        /// <summary>
        /// Enlaza el config con el archivo appsettings.json, para tomar los valore internos 
        /// de este de forma inyeccion de dependencias.
        /// </summary>
        
        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context,config) => {
                config.AddJsonFile("appsettings.json", optional:false,reloadOnChange:true);
            })
            .ConfigureServices((context,servicios) =>
            {
             servicios.RegistroContenedorDependencias();
             servicios.RegistroServiciosDependencias();
             servicios.AddTransient<frmCategoria>();
             servicios.AddTransient<frmProducto>();
            });
        

    }
}