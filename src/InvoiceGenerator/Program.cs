using InvoiceGenerator.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceGenerator
{
    internal static class Program
    {
        /// <summary>
        /// This is the composition root. We will add all of our depenedencies here
        /// to be injected into the running application for us.
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services)
        {
            // Adding a dependecy to the IServiceCollection will ensure that .NET
            // can inject it into any class we need. You will see this in the class
            // constructors - a concrete class will be injected in where we expect
            // an interface.

            // Dependencies can have one of three service lifetimes in .NET's built
            // in DI framework:
            //   - Scoped
            //   - Transient
            //   - Singleton
            // The rule of thumb is that you almost always want Transient, and almost
            // never want a Singleton.
            // See: https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection#service-lifetimes
            // for more information

            services
                // First, inject the Start Screen class, otherwise we can't start the application
                .AddTransient<StartScreen>()
                // Here we are saying that whenever a constructor calls for an IClientService, the
                // DI Container should create a new instance of the ClientService and pass that in
                .AddTransient<IClientService, ClientService>();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);


            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            using (ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider())
            {
                var startScreen = serviceProvider.GetService<StartScreen>();
                Application.Run(startScreen);
            }
        }
    }
}
