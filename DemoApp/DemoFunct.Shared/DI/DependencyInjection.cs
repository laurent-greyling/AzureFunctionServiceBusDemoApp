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
            var container = new ContainerBuilder();

            container.Register(c => new TypeCreator(container))
               .As<ITypeCreator>()
               .SingleInstance();

            container.RegisterType<ServiceBusInitializer>()
                .As<IRunStartup>()
                .InstancePerDependency();

            container.RegisterType<MessageHandlerRegistryInitializer>()
                .As<IRunStartup>()
                .InstancePerDependency();

            container.RegisterType<MessageWrapper>()
                .As<IMessage>()
                .InstancePerLifetimeScope();

            container.RegisterType<MessageHandlerRegistry>()
                .As<IMessageHandlerRegistry>()
                .InstancePerLifetimeScope();

            container.RegisterType<MessageHandler>()
                .As<IMessageHandler>()
                .AsSelf();

            //container.RegisterType<DataCalcMessageHandler>()
            //    .As<IMessageHandler>()
            //    .AsSelf();

            //container.RegisterType<DataExtractMessageHandler>()
            //    .As<IMessageHandler>()
            //    .AsSelf();

            //container.RegisterType<DataTableMessageHandler>()
            //    .As<IMessageHandler>()
            //    .AsSelf();

            return container.Build();
        }
    }
}
