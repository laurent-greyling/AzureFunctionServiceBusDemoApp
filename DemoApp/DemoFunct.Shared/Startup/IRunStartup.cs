using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoFunct.Shared.Startup
{
    public interface IRunStartup
    {
        Task RunAsync();
    }
}
