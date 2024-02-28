

using DTO.Request;

namespace DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
      

        public UserStatisticDto UserStatistic { get; set; }

        public RoomDto Room { get; set; }
        public int? RoomId { get; set; }
    }
}
