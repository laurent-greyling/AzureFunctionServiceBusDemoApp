using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.Messages
{
    public interface IMessage
    {
        string MessageId { get; set; }
        IDictionary<string, object> Properties { get; }

        DateTime ScheduledEnqueueTimeUtc { get; set; }
    }
}
