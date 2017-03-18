using Cascade.Admin;
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

        protected List<FormulaSymbol> _structure;
        protected List<Predicate> _predicates;

        protected Formula(List<FormulaSymbol> structure, List<Predicate> predicates)
        {
            _structure = structure;
            _predicates = predicates;
        }

        protected static List<FormulaSymbol> ParseStructure(string formulaString, out List<string> predicateAliases)
        {
            throw new NotImplementedException();
        }

        protected static List<Predicate> ResolveReferences(IList<string> predicateAliases, IRegistry registry)
        {
            throw new NotImplementedException();
        }
    }
}

// ToDo: Make sure all static methods and variables are in a sensible place within code files.