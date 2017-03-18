using Cascade.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    // A formula with no comparators.
    class Expression : Formula
    {
        private Expression(List<FormulaSymbol> structure, List<Predicate> predicates) : base(structure, predicates)
        { }

        public static Expression Parse(string expressionString, IRegistry registry)
        {
            List<FormulaSymbol> structure;
            List<string> predicateAliases;
            structure = ParseStructure(expressionString, out predicateAliases);

            if (structure.Any(x => IsComparator(x)))
            {
                throw new ArgumentException("Expressions cannot contain comparators.");
            }

            List<Predicate> predicates;
            predicates = ResolveReferences(predicateAliases, registry);

            return new Expression(structure, predicates);
        }
    }
}
