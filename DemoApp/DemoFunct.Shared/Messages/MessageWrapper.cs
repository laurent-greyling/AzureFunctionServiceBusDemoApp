using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.Messages
{
    public class MessageWrapper : IMessage
    {
        public MessageWrapper(Message message)
        {
            Message = message;
        }

        internal Message Message { get; }

        public string MessageId { get => Message.MessageId; set => Message.MessageId = value; }

        public IDictionary<string, object> Properties => Message.UserProperties;

        public DateTime ScheduledEnqueueTimeUtc { get => Message.ScheduledEnqueueTimeUtc; set => Message.ScheduledEnqueueTimeUtc = value; }

    }
}
