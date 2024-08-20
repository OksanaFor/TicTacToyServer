using DAL.Models;


namespace DAL.Base.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //BaseRepository<User, int> Users { get; }
  
        Task SaveAsync();


    }
}
