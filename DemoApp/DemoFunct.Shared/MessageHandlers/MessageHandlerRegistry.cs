using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.MessageHandlers
{
    public class MessageHandlerRegistry : IMessageHandlerRegistry
    {
        private readonly IDictionary<string, Type> _messageTypeHandler = new Dictionary<string, Type>();

        public Type GetMessageTypeHandler(string messageType)
        {
            if (_messageTypeHandler.TryGetValue(messageType, out var commandType))
            {
                return commandType;
            }

            throw new MessageHandlerNotRegisteredException(messageType);
        }

        public void RegisterMessageTypeHandler(string messageType, Type messageHandlerType)
        {
            _messageTypeHandler.Add(messageType, messageHandlerType);
        }
    }
}
