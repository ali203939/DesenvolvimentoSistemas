using WebAPIAula1.Application;
using WebAPIAula1.Infrastructure;
using WebAPIAula1.Infrastructure.Data;
using WebAPIAula1.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Register Application Layer (MediatR, AutoMapper, FluentValidation)
builder.Services.AddApplication();

// Register Infrastructure Layer (DbContext, Repositories)
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Weather Forecast API - Clean Architecture",
        Version = "v1",
        Description = "A Web API built with Clean Architecture principles using .NET 8"
    });
});

var app = builder.Build();

// Initialize database with seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    DbInitializer.Initialize(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use custom exception handling middleware
app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
