using DAL.Base.Interfaces;
using DAL.Base;
using Microsoft.Extensions.DependencyInjection;


namespace DAL
{
    public static class DALDependencyInjection
    {
        public static void AddDAL(this IServiceCollection services)
        {
            services.AddScoped<ITicTacToyEntities, TicTacToyEntities > ();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
     
        }
    }
}
