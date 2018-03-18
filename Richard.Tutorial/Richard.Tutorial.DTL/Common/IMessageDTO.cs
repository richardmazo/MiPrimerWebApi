using System;
using System.Collections;

namespace Richard.Tutorial.DTL
{
    public interface IMessageDTO
    {
        string Code { get; set; }
        string Message { get; set; }
        IList Result { get; set; }
        Exception Error { get; set; }
    }
}