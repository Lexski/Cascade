using Cascade.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    // A formula with exactly one comparator.
    class Rule : Formula
    {
        public static Rule Parse(string expressionString, IRegistry registry)
        {
            List<FormulaSymbol> structure;
            List<string> predicateAliases;
            structure = ParseStructure(expressionString, out predicateAliases);

            if (structure.Count(x => IsComparator(x)) != 1)
            {
                throw new ArgumentException("Rules must contain exactly one comparator.");
            }

            List<Predicate> predicates;
            predicates = ResolveReferences(predicateAliases, registry);

            return new Rule(structure, predicates);
        }

        private Rule(List<FormulaSymbol> structure, List<Predicate> predicates) : base(structure, predicates)
        { }
    }
}
