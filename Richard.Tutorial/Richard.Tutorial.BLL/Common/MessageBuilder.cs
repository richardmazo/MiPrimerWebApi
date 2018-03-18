using Richard.Tutorial.DTL;
using System;
using System.Collections;


namespace Richard.Tutorial.BLL 
{
    public class MessageBuilder : IMessageBuilder
    {
        public void BuildMessage(string Message, string Code, ref IMessageDTO MessageDTO, Exception Error = null, IList Result =null)
        {
            MessageDTO.Code = Code;
            MessageDTO.Result = Result;
            MessageDTO.Message = Message;
            MessageDTO.Error = Error;
        }
    }
}
