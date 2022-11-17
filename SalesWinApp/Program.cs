using BusinessObject.Service;
using Microsoft.Extensions.DependencyInjection;
namespace SalesWinApp
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
            Application.Run(new FrmLogin());
            //Application.Run(new Management());
            //Application.Run(new Member());
            var service = new ServiceCollection();
            service.AddSingleton<IProductService, ProductService>();

        }
    }
}