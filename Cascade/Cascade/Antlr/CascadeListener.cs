using Antlr4.Runtime.Misc;
using Cascade.Logic;

namespace Cascade.Antlr
{
    class CascadeListener : CascadeBaseListener
    {
        // The listener issues commands to the controller.
        private IController _controller;
        private string _objectAlias;

        public CascadeListener(IController controller)
        {
            _controller = controller;
            _objectAlias = null;
        }

        public override void ExitDeclarePredicateNoFormula([NotNull] CascadeParser.DeclarePredicateNoFormulaContext context)
        {
            if (_objectAlias == null)
            {
                _controller.DeclarePredicate(context.predicateName.Text);
            }
            else
            {
                _controller.DeclarePredicate(context.predicateName.Text, _objectAlias);
            }
        }

        public override void ExitDeclarePredicateWithFormula([NotNull] CascadeParser.DeclarePredicateWithFormulaContext context)
        {
            if (_objectAlias == null)
            {
                _controller.DeclarePredicate(context.predicateName.Text, Expression.Parse(context.expressionClause().expression().GetText()));
            }
            else
            {
                _controller.DeclarePredicate(context.predicateName.Text, _objectAlias, Expression.Parse(context.expressionClause().expression().GetText()));
            }
        }

        public override void ExitDeclareTest([NotNull] CascadeParser.DeclareTestContext context)
        {
            if (_objectAlias == null)
            {
                _controller.DeclareTest(context.testName.Text, Expression.Parse(context.expressionClause().expression().GetText()));
            }
            else
            {
                _controller.DeclareTest(context.testName.Text, _objectAlias, Expression.Parse(context.expressionClause().expression().GetText()));
            }
        }

        public override void ExitAssert([NotNull] CascadeParser.AssertContext context)
        {
            _controller.Assert(Formula.Parse(context.formula().GetText()));
        }

        public override void ExitGenerate([NotNull] CascadeParser.GenerateContext context)
        {
            _controller.Generate();
        }

        public override void ExitSave([NotNull] CascadeParser.SaveContext context)
        {
            _controller.Save(context.FilePath().GetText());
        }

        public override void ExitAliasClause([NotNull] CascadeParser.AliasClauseContext context)
        {
            _objectAlias = context.alias.Text;
        }
    }
}

// ToDo: Standardise usage of formula/expression/rule