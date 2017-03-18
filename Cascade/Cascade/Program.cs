using Cascade.Input;
using Cascade.Antlr;

namespace Cascade
{
    static class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            Interpreter interpreter = new Interpreter();

            interpreter.Run(reader);
        }
    }
}
