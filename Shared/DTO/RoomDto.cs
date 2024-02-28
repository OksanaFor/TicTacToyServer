
namespace DTO
{
    public class RoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }

        public ICollection<UserDto> Users { get; }
    }
}
