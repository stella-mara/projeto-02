using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using projeto_02.Database;
using projeto_02.Database.Repositories;
using projeto_02.Database.Repositories.Interfaces;
using projeto_02.Services;
using projeto_02.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FashionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddScoped<IUsuariosService, UsuariosService>();
builder.Services.AddScoped<IUsuariosRepository, UsuariosRepository>();

builder.Services.AddScoped<IColecoesService, ColecoesService>();
builder.Services.AddScoped<IColecoesRepository, ColecoesRepository>();

builder.Services.AddScoped<IModelosService, ModelosService>();
builder.Services.AddScoped<IModelosRepository, ModelosRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<FashionContext>();
    dbContext.Database.EnsureCreated();
}

app.MapControllers();

app.Run();
