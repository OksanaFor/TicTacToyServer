using DAL.Models;


namespace DAL.Base.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        BaseRepository<User, int> Users { get; }
        BaseRepository<UserStatistics, int> Statistics { get; }

        BaseRepository<Room, int> Rooms { get; }    

        Task SaveAsync();


    }
}
