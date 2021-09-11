using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using System.Text;
using System.Threading.Tasks;

namespace ServicebusMessageSender
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = "";
            var queueName = "mgm";

            var sender = new MessageSender(connectionString, queueName);

            var msg = new Message
            {
                Label = "Hello world!",
                Body = Encoding.UTF8.GetBytes("Hello world!"),                
            };

            msg.UserProperties.Add("MessageType", "FetchData");

            await sender.SendAsync(msg);
        }
    }
}
