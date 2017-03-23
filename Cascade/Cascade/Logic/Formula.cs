using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Cascade.Admin;
using Cascade.Antlr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    // A logical formula involving predicates, operators, comparators and brackets.
    abstract class Formula
    {
        public static bool IsComparator(FormulaSymbol symbol)
        {
            switch (symbol)
            {
                case FormulaSymbol.Excludes:
                case FormulaSymbol.Implies:
                case FormulaSymbol.Iff:
                case FormulaSymbol.CoversAllCases:
                    return true;
                default:
                    return false;
            }
        }

        protected static List<FormulaSymbol> ParseStructure(string formulaString, out List<string> predicateAliases)
        {
            // Parse the formula.
            AntlrInputStream stream = new AntlrInputStream(formulaString);
            FormulaLexer lexer = new FormulaLexer(stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            FormulaParser parser = new FormulaParser(tokens);
            IParseTree tree = parser.formula();

            // Obtain the formula structure and predicate aliases.
            ParseTreeWalker walker = new ParseTreeWalker();
            FormulaListener listener = new FormulaListener();
            walker.Walk(listener, tree);

            predicateAliases = listener.GetPredicateAliases();
            return listener.GetFormulaStructure();
        }

        protected static List<Predicate> ResolveReferences(IList<string> predicateAliases, IRegistry registry)
        {
            return predicateAliases.Select(x => registry.GetObject<Predicate>(x)).ToList();
        }

        protected List<FormulaSymbol> _structure;
        protected List<Predicate> _predicates;

        protected Formula(List<FormulaSymbol> structure, List<Predicate> predicates)
        {
            _structure = structure;
            _predicates = predicates;
        }
    }
}