using DemoFunct.Shared.Startup;
using Microsoft.Azure.ServiceBus.Management;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.DI
{
    public class ServiceBusInitializer : IRunStartup
    {
        public async Task RunAsync()
        {
            //var config = new ConfigurationBuilder()
            //    .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
            //    .AddEnvironmentVariables()
            //    .Build();

            //var serviceBusConnectionString = config["Values:AzureWebJobsServiceBus"];
            //var namespaceManager = new ManagementClient(serviceBusConnectionString);

            //await EnsureQueueExists(namespaceManager, "mgm");
            //await EnsureQueueExists(namespaceManager, "work");
        }
        private static async Task EnsureQueueExists(ManagementClient namespaceManager, string queueName)
        {
            var queueExists = await namespaceManager.QueueExistsAsync(queueName);

            if (!queueExists)
            {
                await namespaceManager.CreateQueueAsync(
                    new QueueDescription(queueName));
            }
        }

    }
}
