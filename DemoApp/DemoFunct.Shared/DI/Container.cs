using Autofac;
using DemoFunct.Shared.MessageHandlers;
using DemoFunct.Shared.Messages;
using DemoFunct.Shared.Startup;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.DI
{
    public static class Container
    {
        public static ContainerBuilder Builder()
        {
            var container = new ContainerBuilder();

            container.RegisterType<TypeCreator>()
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

            return container;
        }
    }
}
