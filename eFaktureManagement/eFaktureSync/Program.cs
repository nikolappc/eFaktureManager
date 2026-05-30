// See https://aka.ms/new-console-template for more information
using eFaktureManagement.ApiServices;
using eFaktureManagement.Data;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Sales;
using eFaktureSync.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

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
    })
    .ConfigureServices((context, serviceCollection) =>
    {

       
        serviceCollection.AddDbContext<eFaktureContext>(options =>
            options.UseSqlServer(
            context.Configuration.GetConnectionString("eFaktureConnection")));


        serviceCollection.AddScoped<ISyncService, PurchaseSyncService>();
        serviceCollection.AddScoped<ISyncService, SalesSyncService>();
        serviceCollection.AddScoped<IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, ApiSaleInvoiceService>();
        serviceCollection.AddScoped<IApiInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>, ApiPurchaseInvoiceService>();
        serviceCollection.AddHostedService<SyncBackgroundService>();

    })
    .Build();



await host.RunAsync();

