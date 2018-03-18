using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard.Tutorial.DTL
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        //public CountryDTO Countries { get; set; }
        //public List<UserDTO> Users { get; set; }
    }
}
