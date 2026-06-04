using eFaktureManagement.ApiServices;
using eFaktureModel.Api.Config;
using eFaktureModel.Api.Models.Purchase;
using eFaktureModel.Api.Models.Sales;
using eFaktureModel.ApiServices;
using eFaktureModel.Enums;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", false)
.AddEnvironmentVariables()
.Build();

var settings = config.GetSection("ApiConfig").Get<EFaktureApiRoot>();

builder.Services.AddSingleton<EFaktureApiRoot>(settings);

builder.Services.AddScoped<AApiSalesService, ApiSaleInvoiceService>();
builder.Services.AddScoped<AApiPurchaseInvoiceService<PurchaseInvoiceStatusChangeDto, SimplePurchaseInvoiceDto>, ApiPurchaseInvoiceService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
