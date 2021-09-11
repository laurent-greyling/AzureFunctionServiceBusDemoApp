using DemoFunct.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.MessageHandlers
{
    public interface IMessageHandler
    {
        Task HandleAsync(IMessage message);
    }
}
