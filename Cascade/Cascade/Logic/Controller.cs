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

        public void DeclarePredicate(string name, string alias)
        {
            Predicate.CreateAndRegister(name, alias, _registry);
        }

        public void DeclarePredicate(string name, Expression expression)
        {
            Predicate.CreateAndRegister(name, expression, _registry);
        }

        public void DeclarePredicate(string name, string alias, Expression expression)
        {
            Predicate.CreateAndRegister(name, alias, expression, _registry);
        }

        public void DeclareTest(string name, Expression expression)
        {
            Test.CreateAndRegister(name, expression, _registry);
        }

        public void DeclareTest(string name, string alias, Expression expression)
        {
            Test.CreateAndRegister(name, alias, expression, _registry);
        }

        public void Assert(Rule rule)
        {
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
