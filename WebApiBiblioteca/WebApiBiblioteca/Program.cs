using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Data;
using WebApiBiblioteca.Services;
using WebApiBiblioteca.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// ── 1. DbContext ──────────────────────────────────────────────────────────────
builder.Services.AddDbContext<BibliotecaSQLServerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ── 2. Services (Injeção de Dependência) ─────────────────────────────────────
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<IEmprestimoService, EmprestimoService>();


var app = builder.Build();

// ── Pipeline HTTP ──────────────────────────────────────────────────────────────
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();