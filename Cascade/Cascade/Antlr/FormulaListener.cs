using Antlr4.Runtime.Misc;
using Cascade.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;

namespace Cascade.Antlr
{
    class FormulaListener : FormulaBaseListener
    {
        private List<FormulaSymbol> _formulaStructure;
        private List<string> _predicateAliases;

        // Add the correct symbols and aliases.
        public override void VisitTerminal([NotNull] ITerminalNode node)
        {
            if (node.Symbol.Text == "(")
            {
                _formulaStructure.Add(FormulaSymbol.OpenBracket);
                return;
            }

            if (node.Symbol.Text == ")")
            {
                _formulaStructure.Add(FormulaSymbol.CloseBracket);
                return;
            }

            switch (node.Symbol.Type)
            {
                case FormulaLexer.CP1_CoversAllCases:
                    _formulaStructure.Add(FormulaSymbol.CoversAllCases);
                    return;
                case FormulaLexer.OP2_And:
                    _formulaStructure.Add(FormulaSymbol.And);
                    return;
                case FormulaLexer.CP2_Excludes:
                    _formulaStructure.Add(FormulaSymbol.Excludes);
                    return;
                case FormulaLexer.CP2_Iff:
                    _formulaStructure.Add(FormulaSymbol.Iff);
                    return;
                case FormulaLexer.CP2_Implies:
                    _formulaStructure.Add(FormulaSymbol.Implies);
                    return;
                case FormulaLexer.OP1_Not:
                    _formulaStructure.Add(FormulaSymbol.Not);
                    return;
                case FormulaLexer.OP2_Or:
                    _formulaStructure.Add(FormulaSymbol.Or);
                    return;
                case FormulaLexer.OP2_Xor:
                    _formulaStructure.Add(FormulaSymbol.Xor);
                    return;
                case FormulaLexer.Identifier:
                    _formulaStructure.Add(FormulaSymbol.Predicate);
                    _predicateAliases.Add(node.Symbol.Text);
                    return;
                default:
                    throw new ArgumentException($"Unrecognised formula symbol {node.Symbol.Text}");
            }
        }

        public List<FormulaSymbol> GetFormulaStructure()
        {
            return new List<FormulaSymbol>(_formulaStructure);
        }

        public List<string> GetPredicateAliases()
        {
            return new List<string>(_predicateAliases);
        }
    }
}
