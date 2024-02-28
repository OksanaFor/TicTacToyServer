using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Request
{
    public class UserStatisticDto
    {
        public int Id { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Drow { get; set; }
        public int Rating { get; set; }

        public UserDto User { get; set; }
        public int UserId { get; set; }
    }
}

