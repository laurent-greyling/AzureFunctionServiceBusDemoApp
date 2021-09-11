using Autofac;
using DemoFunct.Shared.DI;
using DemoFunct.Shared.MessageHandlers;
using DemoFunct.Shared.Startup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public static class Startup
    {
        private static IContainer _container;

        public static async Task<IContainer> BuildContainer() 
        {
            if (_container != null)
            {
                return _container;
            }

            var container = DependencyInjection.Initialize();

            var startupTasks = container.Resolve<IEnumerable<IRunStartup>>();

            foreach (var task in startupTasks)
            {
                await task.RunAsync();
            }

            _container = container;

            return _container;
        }

        public static async Task<IMessageHandler> GetMessageHandlerAsync()
        {
            var container = await BuildContainer();
            return container.Resolve<IMessageHandler>();
        }
    }
}
