using DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public interface ITicTacToyEntities
    {
        DbSet<User> Users { get; set; }

        DbSet<UserStatistics> UserStatistics { get; set; }
        DbSet<Room> Rooms { get; set; }

    }
}