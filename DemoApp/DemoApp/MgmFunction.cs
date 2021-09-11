using System;
using System.Threading.Tasks;
using DemoFunct.Shared.Messages;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DemoApp
{
    public static class MgmFunction
    {
        [FunctionName("MgmFunction")]
        public static async Task Run([ServiceBusTrigger("mgm")] Message message)
        {
            var messageHandler = await Startup.GetMessageHandlerAsync();
            await messageHandler.HandleAsync(new MessageWrapper(message));
        }
    }
}
