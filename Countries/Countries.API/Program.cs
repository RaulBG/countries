using Common.Settings;
using Countries.Infraestructure.EF;
using Countries.Infraestructure.Repositories;
using MediatR;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddMediatR(typeof(Program));
builder.Services.AddMediatR(AppDomain.CurrentDomain.Load("Countries.Application")); //Esposible que se necesesite => AppDomain.CurrentDomain.Load("Common.Settings")


builder.Services.AddDbContext<CountriesDbContext>();

builder.Services.AddScoped<IDatabaseSettings, DatabaseSettings>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();



//Configuration
//using IHost host = Host.CreateDefaultBuilder(args).Build();
//IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
////string con = config.GetValue<string>("ConnectionStrings:conn1");
//////OR
//string connectionString = config["ApplicationsSettings:Contries:ConnectionStrings:DefaultConnection"];


var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//   var contex= scope.ServiceProvider.GetRequiredService<CountriesDbContext>();
//    contex.Database.Migrate();
//}


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

///// <summary>
///// Aplicar MIgraciones del DbContext
///// </summary>
///// <param name="platformSettings"></param>
//public void ApplyMigrations(IPlatformSettings platformSettings)
//{
//    InvoicesDbContext.MigrateApplications<InvoicesDbContext>(platformSettings);
//}
