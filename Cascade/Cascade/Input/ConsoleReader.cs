using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Input
{
    // Reads from the console.
    public class ConsoleReader : IReader
    {
        private string _prompt;

        public ConsoleReader()
        {
            _prompt = ">> ";
        }

        public bool ReadInto(out string text)
        {
            Console.Write(_prompt);
            text = Console.ReadLine();
            return true;
        }
    }
}