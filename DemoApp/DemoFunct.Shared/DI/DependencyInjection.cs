using Autofac;
using DemoFunct.Shared.MessageHandlers;
using DemoFunct.Shared.Messages;
using DemoFunct.Shared.Startup;

namespace DemoFunct.Shared.DI
{
    public static class DependencyInjection
    {
        public static IContainer Initialize() 
        {
            var container = Container.Builder();

            return container.Build();
        }
    }
}
