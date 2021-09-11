using Autofac;
using DemoFunct.Shared.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.DI
{
    public class TypeCreator : ITypeCreator
    {
        private readonly ContainerBuilder _container;

        public TypeCreator(ContainerBuilder container)
        {
            _container = container;
        }

        public object Create(Type typeToCreate)
        {
            var newBuilder = new ContainerBuilder();
            newBuilder.RegisterType(typeToCreate);
            var container = newBuilder.Build();
            
            return container.Resolve(typeToCreate);
        }
    }
}
