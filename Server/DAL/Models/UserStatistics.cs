

namespace DAL.Models
{
    public class UserStatistics
    {
        public int Id { get; set; }
        public int Win {  get; set; }
        public int Lose { get; set; }
        public int Drow { get; set; }   

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
