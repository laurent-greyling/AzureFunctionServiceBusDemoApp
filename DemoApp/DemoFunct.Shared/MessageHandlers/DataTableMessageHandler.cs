using DemoFunct.Shared.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.MessageHandlers
{
    public class DataTableMessageHandler : IMessageHandler
    {
        public async Task HandleAsync(IMessage message)
        {
            var x = "DataTable";
        }
    }
}
