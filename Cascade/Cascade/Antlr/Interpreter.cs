using Cascade.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Antlr
{
    // An object that is given text (Cascade code) and issues commands based on it.
    class Interpreter
    {
        public void Run(IReader reader)
        {
            string cascadeInput;
            while (reader.ReadInto(out cascadeInput))
            {
                // Parse the text and perform actions using a listener.
            }
        }
    }
}
