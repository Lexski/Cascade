using Cascade.Input;
using Cascade.Antlr;
using Cascade.Logic;

namespace Cascade
{
    static class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IController controller = new Controller();
            IInterpreter interpreter = new Interpreter();

            interpreter.Run(reader, controller);
        }
    }
}
