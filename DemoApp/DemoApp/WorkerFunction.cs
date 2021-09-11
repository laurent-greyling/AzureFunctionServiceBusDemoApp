using System;
using System.Threading.Tasks;
using DemoFunct.Shared.Messages;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Management;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DemoApp
{
    public static class WorkerFunction
    {
        [FunctionName("WorkerFunction")]
        public static async Task Run([ServiceBusTrigger("work")] Message message)
        {
            var messageHandler = await Startup.GetMessageHandlerAsync();
            await messageHandler.HandleAsync(new MessageWrapper(message));
        }
    }
}
