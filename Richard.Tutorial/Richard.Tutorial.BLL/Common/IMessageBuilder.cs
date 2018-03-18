using System.Collections;
using Richard.Tutorial.DTL;
using System;

namespace Richard.Tutorial.BLL
{
    public interface IMessageBuilder
    {
        void BuildMessage(string Message, string Code, ref IMessageDTO MessageDTO, Exception Error = null, IList Result = null);
    }
}