using System;
using System.Collections.Generic;

namespace Richard.Tutorial.DTL
{
    public class OrdersDTO
    {
        public int OrderId { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? Value { get; set; }
        public List<OrdersByUserDTO> OrdersByUser { get; set; }
    }
}