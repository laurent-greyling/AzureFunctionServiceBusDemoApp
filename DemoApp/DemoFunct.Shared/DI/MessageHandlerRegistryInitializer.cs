using DemoFunct.Shared.MessageHandlers;
using DemoFunct.Shared.Messages;
using DemoFunct.Shared.Startup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.DI
{
    public class MessageHandlerRegistryInitializer : IRunStartup
    {
        private readonly IMessageHandlerRegistry _commandRegistry;

        public MessageHandlerRegistryInitializer(
            IMessageHandlerRegistry commandFactory
            )
        {
            _commandRegistry = commandFactory;
        }

        public Task RunAsync()
        {
            _commandRegistry.RegisterMessageTypeHandler(MessageTypes.DataExtract, typeof(DataExtractMessageHandler));
            _commandRegistry.RegisterMessageTypeHandler(MessageTypes.DataCalc, typeof(DataCalcMessageHandler));
            _commandRegistry.RegisterMessageTypeHandler(MessageTypes.DataTable, typeof(DataTableMessageHandler));
            _commandRegistry.RegisterMessageTypeHandler(MessageTypes.FetchData, typeof(FetchDataMessageHandler));

            return Task.CompletedTask;
        }
    }
}
