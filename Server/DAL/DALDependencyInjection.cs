using DAL.Base.Interfaces;
using DAL.Base;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;


namespace DAL
{
    public static class DALDependencyInjection
    {
        public static void AddDAL(this IServiceCollection services)
        {
            services.AddScoped<ITicTacToyEntities, TicTacToyEntities > ();
            services.AddTransient<BaseRepository<User, int>>();
            services.AddTransient<BaseRepository <UserStatistics,int>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<BaseRepository<Room, int>>();
        }
    }
}
