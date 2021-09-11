using System;
using System.Collections.Generic;
using System.Text;

namespace DemoFunct.Shared.DI
{
    public interface ITypeCreator
    {
        object Create(Type typeToCreate);
    }
}
