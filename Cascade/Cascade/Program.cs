using Cascade.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade
{
    static class Program
    {
        public static IReader Reader { get; private set; }

        static void Main(string[] args)
        {
            Reader = new ConsoleReader();
        }
    }
}
