using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMovie.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructurePersistence(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly(typeof(MovieDbContext).Assembly.FullName)), ServiceLifetime.Transient);
            return services;
        }
    }
}
