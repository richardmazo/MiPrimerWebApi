using Richard.Tutorial.DTL;
using System.Collections.Generic;

namespace Richard.Tutorial.DTL
{
    public class CountryDTO
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<CityDTO> Cities { get; set; }
    }
}