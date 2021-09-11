using DemoFunct.Shared.DI;
using DemoFunct.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.MessageHandlers
{
    public class FetchDataMessageHandler : IMessageHandler
    {
        private readonly ITypeCreator _creator;

        public FetchDataMessageHandler(ITypeCreator creator)
        {
            _creator = creator;
        }

        public async Task HandleAsync(IMessage message)
        {
            var d = message;
            var x = _creator;
            var y = "FetchData";
        }
    }
}
