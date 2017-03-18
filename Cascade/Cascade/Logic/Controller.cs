using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    class Controller : IController
    {
        public void DeclarePredicate(string name)
        {
            Predicate.CreateAndRegister(name);
        }

        public void DeclarePredicate(string name, string alias)
        {
            Predicate.CreateAndRegister(name, alias);
        }

        public void DeclarePredicate(string name, Expression expression)
        {
            Predicate.CreateAndRegister(name, expression);
        }

        public void DeclarePredicate(string name, string alias, Expression expression)
        {
            Predicate.CreateAndRegister(name, alias, expression);
        }

        public void DeclareTest(string name, Expression expression)
        {
            Test.CreateAndRegister(name, expression);
        }

        public void DeclareTest(string name, string alias, Expression expression)
        {
            Test.CreateAndRegister(name, alias, expression);
        }

        public void Assert(Rule rule)
        {
            throw new NotImplementedException();
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
