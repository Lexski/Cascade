using Cascade.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade
{
    // Represents an object that is given text and issues commands based on it.
    interface IInterpreter
    {
        void Run(IReader reader);
    }
}
