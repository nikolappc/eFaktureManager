using eFaktureManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.CodeAnalysis;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("eFaktureConnection") ?? throw new InvalidOperationException("Connection string 'eFaktureContextConnection' not found.");

//var ConnectionString = builder.Configuration["Connnectionstrings:eFaktureConnection"];


builder.Services.AddDbContext<eFaktureContext>(e => e.UseNpgsql(connectionString)).AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<eFaktureContext>();


// Add services to the container.
builder.Services.AddHttpClient();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Required for keycloak
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
    {
        // Set the metadata address for the OpenID configuration
        o.MetadataAddress = "http://localhost:9091/realms/eFakture/.well-known/openid-configuration";

        // Set the authority for the authentication server
        o.Authority = "http://localhost:9091/realms/eFakture";

        // Set the audience for the JWT token
        o.Audience = "account";

        // For testing, you might want to disable HTTPS metadata requirement
        // Set this to true in production for security
        o.RequireHttpsMetadata = false;
    });



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
