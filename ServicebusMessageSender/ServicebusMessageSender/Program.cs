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
            var connectionString = "Endpoint=sb://qrmplaytest.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=Rf1+69KGCE/Jb+HRlLXNPy4baVzdyDIQ0MyEgXS/5s8=";
            var queueName = "mgm";

            var sender = new MessageSender(connectionString, queueName);

            var msg = new Message
            {
                Label = "Hello world!",
                Body = Encoding.UTF8.GetBytes("Hello world!"),                
            };

            //msg.UserProperties.Add("MessageType", "DataCalc");
            //msg.UserProperties.Add("MessageType", "DataExtract");
            msg.UserProperties.Add("MessageType", "DataTable");
            //msg.UserProperties.Add("MessageType", "FetchData");

            await sender.SendAsync(msg);
        }
    }
}
