

namespace DAL.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        public ICollection<User> Users { get;}

    }
}
