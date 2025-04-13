using app.projectCastroDubraska.DataAccess;
using app.projectCastroDubraska.DataAccess.context;
using app.projectCastroDubraska.Services.Implementations;
using app.projectCastroDubraska.Services.Interfaces;
using app.projectCastroDubraska.DataAccess.Repositorio;
using Microsoft.EntityFrameworkCore;
using app.projectCastroDubraska.common.EventMQ;
using app.projectCastroDubraska.Services.EventMQ;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//LA CADENA DE CONEXION ESTA EN EL appsettings.json
//CON EL SIGUIENTA LINEA OBTENEMOS LA CADENA DE CONEXIONA SQL SERVER
var conSqlServer = builder.Configuration.GetConnectionString("BDDSqlServer")!;
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(conSqlServer);
    options.LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging();
});

// Builder de categoria
builder.Services.AddScoped<iCategoriaService, CategoriaService>();
builder.Services.AddScoped<iCategoriaRepositorio, CategoriaRepository>();

//Builder de cliente
builder.Services.AddScoped<iClienteService, ClienteService>();
builder.Services.AddScoped<iClienteRepositorio, ClienteRepositorio>();

//builder de producto
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<iProductoRepositorio, ProductoRepository>();

//builder de venta
builder.Services.AddScoped<IVentaService, VentaService>();
builder.Services.AddScoped<IVentaRepository, VentaRepository>();

//builder de venta detalle
builder.Services.AddScoped<IVentaDetalleService, VentaDetalleService>();
builder.Services.AddScoped<iVentaDetalleRepositorio, VentaDetalleRepository>();

//builder de usuario
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<iUsuarioRepositorio, UsuarioRepository>();

//rabbitmq
builder.Services.Configure<RabbitMQSettings>(builder.Configuration.GetSection("rabbitmq"));
builder.Services.AddSingleton<iRabbitMQService, RabbitMQService>();

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
