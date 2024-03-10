
namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserStatistics? UserStatistics { get; set; }  
        
        public Room? Room { get; set; }
        public int? RoomId { get; set; }

    }
}
