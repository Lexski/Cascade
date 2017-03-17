using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Input
{
    // Represents an object that retrieves text input for the program.
    interface IReader
    {
        // Returns false when there is nothing left to read.
        bool Read(out string input);
    }
}
