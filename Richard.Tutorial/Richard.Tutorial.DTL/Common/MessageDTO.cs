using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Richard.Tutorial.DTL
{
    public class MessageDTO : IMessageDTO
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public IList Result { get; set; }

        public Exception Error   { get; set; } 

    }
}
