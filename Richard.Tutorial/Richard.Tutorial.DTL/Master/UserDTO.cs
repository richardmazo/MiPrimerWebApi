using Richard.Tutorial.DTL;
using System.Collections.Generic;

namespace Richard.Tutorial.DTL
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public CityDTO Cities { get; set; }
        public List<OrdersByUserDTO> OrdersByUser { get; set; }

    }
}