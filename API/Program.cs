using API.Extensions;
using System.Diagnostics;
using DotNetEnv;
using API.Config;
using API.Utils;
using Microsoft.Extensions.Logging;

Env.Load();

var builder = WebApplication.CreateBuilder(args);


// MONGO
var mongoSettings = new MongoDbSettings
{
    ConnectionString = Environment.GetEnvironmentVariable("MONGO_CONN_STRING")!,
    DatabaseName = Environment.GetEnvironmentVariable("MONGO_DB_NAME")!
};

builder.Services.AddSingleton(mongoSettings);
builder.Services.AddSingleton<MongoDbContext>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServices();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("/", () => "✅ API en marcha 🚀");  

app.MapControllers();

// COMPROBATION
var dbContext = app.Services.GetRequiredService<MongoDbContext>();

app.Run();