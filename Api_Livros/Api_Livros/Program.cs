using Api_Livros.Data;
using Api_Livros.Services.Autor;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//[3] Estou indicando que Os metodos de IAutorInterface estão também em AutorService
builder.Services.AddScoped<IAutorInterface, AutorService>();

// [2] LINKAGEM DO ConnectionStrings do appsettings.json com o AppDbcontext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    /* [2] indicando que vou usar o SQL SERVER e que a configuração está em 
           ConnectionString na DefaultConnection */
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); 

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
