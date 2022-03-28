﻿using Budget_ClassLib.Models;
using BudgetApp_WPF.Core.Commands;
using BudgetApp_WPF.Core.Enums;
using BudgetApp_WPF.Core.Factories;
using BudgetApp_WPF.MVVM.ViewModels;
using BudgetApp_WPF.MVVM.ViewModels.NavigationVM;
using BudgetApp_WPF.MVVM.ViewModels.UserVM;
using BudgetDB_APIAccess_ClassLib.API;
using BudgetDB_APIAccess_ClassLib.API.Interfaces;
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
            Configuration = BuildConfiguration();
            serviceProvider = CreateServiceProvider();
            Window window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();

        }


        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
            services.AddScoped<MainViewModel>();
            






            // View Factories
            services.AddTransient<IAbstractViewModelFactory<object, MainMenuOptionsEnum>,MainNavViewModelFactory>();
            services.AddTransient<IViewModelFactory<UserDashBoardViewModel,User>,UserDashBoardViewModelFactory>();
            //






            // Navigation
            services.AddTransient<MainNavigationViewModel>();
            //





            // Commands
            //









            // NOTE: Test connection out ONLY
            // Later the classe in the list will
            // Depending on the needs...
            services.AddSingleton<IAPIClient, APIClient>();
            services.AddTransient<IAPIEndpoint<User, int>, UsersDataEndpoint>();


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
