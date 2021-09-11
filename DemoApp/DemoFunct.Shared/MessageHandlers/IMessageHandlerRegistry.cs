using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.MessageHandlers
{
    public interface IMessageHandlerRegistry
    {
        void RegisterMessageTypeHandler(string messageType, Type messageHandlerType);

        Type GetMessageTypeHandler(string messageType);
    }
}
