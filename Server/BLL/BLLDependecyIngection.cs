using BLL.Interfases;
using BLL.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BLL
{
    public static class BLLDependecyIngection
    {
        public static void AddServiceModule(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
  
        }
    }
}
