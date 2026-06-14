// See https://aka.ms/new-console-template for more information
using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Config;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.ApiServices;
using eFaktureModel.Services.Sync;
using eFaktureSync.Config;
using eFaktureSync.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using PurchaseSyncService = eFaktureSync.Services.PurchaseSyncService;
using SalesSyncService = eFaktureSync.Services.SalesSyncService;

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build())
    .CreateLogger();




var host = Host.CreateDefaultBuilder(args)
        .UseSerilog()
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        config.AddEnvironmentVariables();   
    })
    .ConfigureServices((context, serviceCollection) =>
    {

       
        serviceCollection.AddDbContext<eFaktureContext>(options =>
            options.UseSqlServer(
            context.Configuration.GetConnectionString("eFaktureConnection")));


        var apiroot = new SyncApiRoot();

        context.Configuration.GetSection("ApiConfig").Bind(apiroot);    

        serviceCollection.AddSingleton<SyncApiRoot>(apiroot);

        serviceCollection.AddScoped<ISyncService, PurchaseSyncService>();
        serviceCollection.AddScoped<ISyncService, SalesSyncService>();
        serviceCollection.AddHostedService<SyncBackgroundService>();

    })
    .Build();



await host.RunAsync();

