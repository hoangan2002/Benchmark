using Benchmark.Abstractions;
using Benchmark.Applications.Implements;
using Benchmark.Applications.Interfaces;
using Benchmark.Infrastructure;
using Benchmark.Infrastructure.Configurations;
using Benchmark.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Benchmark.DependencyInjection.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static void AddSqlConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                        options => options.MigrationsAssembly("Benchmark")
                     //   .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                        ));
        }
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            
            services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddTransient(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));
            services.AddTransient(typeof(IRepositoryBaseGood<,>), typeof(RepositoryBaseGood<,>));

            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IStudentServiceGood, StudentServiceGood>();
        }

    }
}
