// See https://aka.ms/new-console-template for more information
using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Models;
using eFaktureSync.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    })
    .ConfigureServices((context, serviceCollection) =>
    {

        //serviceCollection.Configure<IConfiguration>(context.Configuration);
        serviceCollection.AddScoped<ISyncService, SyncService>();
        serviceCollection.AddScoped<IApiInvoiceService<SalesInvoiceStatusChangeDto, SimpleSalesInvoiceDto>, ApiSaleInvoiceService>();

    })
    .Build();

var syncService = host.Services.GetRequiredService<ISyncService>();


await syncService.SyncAsync();