using DemoFunct.Shared.DI;
using DemoFunct.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.MessageHandlers
{
    public class MessageHandler : IMessageHandler
    {
        private readonly IMessageHandlerRegistry _messageHandlerRegistry;
        private readonly ITypeCreator _typeCreator;

        public MessageHandler(IMessageHandlerRegistry messageHandlerRegistry,
            ITypeCreator typeCreator)
        {
            _messageHandlerRegistry = messageHandlerRegistry;
            _typeCreator = typeCreator;
        }

        public async Task HandleAsync(IMessage message)
        {
            var handler = CreateMessageHandler(message);
            await handler.HandleAsync(message);
        }

        private IMessageHandler CreateMessageHandler(IMessage message)
        {
            var messageType = message.Properties["MessageType"].ToString();
            var messageHandlerType = _messageHandlerRegistry.GetMessageTypeHandler(messageType);
            
            return (IMessageHandler)_typeCreator.Create(messageHandlerType);
        }
    }
}
