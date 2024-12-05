using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Infrastructure.Data;
using System.Runtime.CompilerServices;

namespace Store.Infrastructure
{
    public static class InfrastructureRegisteration
    {
        public static void AddStoreDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
