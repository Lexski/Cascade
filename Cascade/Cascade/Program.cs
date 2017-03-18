﻿using Cascade.Input;
using Cascade.Antlr;

namespace Cascade
{
    static class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IInterpreter interpreter = new Interpreter();

            interpreter.Run(reader);
        }
    }
}
