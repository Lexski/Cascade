using Cascade.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    class Controller : IController
    {
        private Registry _registry;

        public Controller()
        {
            _registry = new Registry();
        }

        public void DeclarePredicate(string name)
        {
            Predicate.CreateAndRegister(name, _registry);
        }

        public void DeclarePredicateWithAlias(string name, string alias)
        {
            Predicate.CreateAndRegister(name, alias, _registry);
        }

        public void DeclarePredicateByExpression(string name, string expressionString)
        {
            Expression expression = Expression.Parse(expressionString, _registry);
            Predicate.CreateAndRegister(name, expression, _registry);
        }

        public void DeclarePredicateWithAliasByExpression(string name, string alias, string expressionString)
        {
            Expression expression = Expression.Parse(expressionString, _registry);
            Predicate.CreateAndRegister(name, alias, expression, _registry);
        }

        public void DeclareTest(string name, string expressionString)
        {
            Expression expression = Expression.Parse(expressionString, _registry);
            Test.CreateAndRegister(name, expression, _registry);
        }

        public void DeclareTestWithAlias(string name, string alias, string expressionString)
        {
            Expression expression = Expression.Parse(expressionString, _registry);
            Test.CreateAndRegister(name, alias, expression, _registry);
        }

        public void Assert(string ruleString)
        {
            Rule rule = Rule.Parse(ruleString, _registry);
            _registry.RegisterAnonymously(rule);
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public void Save(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
