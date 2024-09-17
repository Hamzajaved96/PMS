using Microsoft.Extensions.DependencyInjection;
using PMS.Application.IServices;
using PMS.Application.IServices.Services;

namespace PMS.Application
{
    public static class IServiceCollectionExtention
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddTransient<IUserService,UserService>();
           
          

            return services;
        }
    }
}
