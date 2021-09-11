using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.MessageHandlers
{
    public class MessageHandlerNotRegisteredException: Exception
    {
        private readonly string _messageType;

        public MessageHandlerNotRegisteredException(string messageType)
        {
            _messageType = messageType;
        }

        public override string Message => $"No handler registered for message type: {_messageType}";
    }
}
