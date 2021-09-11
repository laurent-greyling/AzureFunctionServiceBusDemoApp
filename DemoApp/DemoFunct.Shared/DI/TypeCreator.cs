using Autofac;
using DemoFunct.Shared.MessageHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.DI
{
    public class TypeCreator : ITypeCreator
    {
        public object Create(Type typeToCreate)
        {
            var newBuilder = Container.Builder();
            newBuilder.RegisterType(typeToCreate);
            var container = newBuilder.Build();
            
            return container.Resolve(typeToCreate);
        }
    }
}
