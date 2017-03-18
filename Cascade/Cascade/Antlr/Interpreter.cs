using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Cascade.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Antlr
{
    // Reads Cascade code and processes it using Antlr.
    class Interpreter : IInterpreter
    {
        public void Run(IReader reader, IController controller)
        {
            string cascadeInput;
            while (reader.ReadInto(out cascadeInput))
            {
                try
                {
                    // Parse the text.
                    AntlrInputStream stream = new AntlrInputStream(cascadeInput);
                    CascadeLexer lexer = new CascadeLexer(stream);
                    CommonTokenStream tokens = new CommonTokenStream(lexer);
                    CascadeParser parser = new CascadeParser(tokens);
                    IParseTree tree = parser.command();

                    // Perform actions using the listener and controller.
                    ParseTreeWalker walker = new ParseTreeWalker();
                    CascadeListener listener = new CascadeListener(controller);
                    walker.Walk(listener, tree);
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.Message);
                }
            }
            
        }
    }
}
