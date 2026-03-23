using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiArquiteturaLimpa.Infrastructure.Persistence.Context;

namespace WebApiArquiteturaLimpa.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        // Registre aqui os repositórios concretos:
        // services.AddScoped<IMinhaEntidadeRepository, MinhaEntidadeRepository>();

        return services;
    }
}
