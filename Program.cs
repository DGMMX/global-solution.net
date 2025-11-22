using FutureOfWork.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Controllers (para sua API funcionar)
builder.Services.AddControllers();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = builder.Configuration["Swagger:Title"] ?? "TalentMind API",

        Description = (builder.Configuration["Swagger:Description"] ?? "Documentação da API ") 
                      + DateTime.Now.Year,

        Contact = new OpenApiContact
        {
            Email = "rm558710@fiap.com.br",
            Name = "Diego Bassalo"
        }
    });
});

// EF Core + SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Swagger apenas em desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TalentMind API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Mapeia os controllers automaticamente
app.MapControllers();

app.Run();
