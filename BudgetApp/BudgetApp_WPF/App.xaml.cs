using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BudgetApp_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        IServiceProvider serviceProvider;
        IConfiguration Configuration { get; set; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }


        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(Configuration);


            return services.BuildServiceProvider();
        }


        private IConfiguration BuildConfiguration()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            return builder.Build();
        }
    }
}
