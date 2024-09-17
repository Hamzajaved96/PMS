using Microsoft.Extensions.DependencyInjection;
using PMS.Presistance.Reposotries.IRepsoitory;
using PMS.Presistance.Reposotries;

namespace PMS.Presistance
{
    public static class IServiceCollectionExtention
    {
        public static IServiceCollection AddPresistance(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository> ();
            return services;
        }
    }
}
