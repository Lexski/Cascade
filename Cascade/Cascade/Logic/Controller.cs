using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    class Controller : IController
    {
        public void Assert(Rule formula)
        {
            throw new NotImplementedException();
        }

        public void DeclarePredicate(string name)
        {
            throw new NotImplementedException();
        }

        public void DeclarePredicate(string name, Expression expression)
        {
            throw new NotImplementedException();
        }

        public void DeclarePredicate(string name, string alias)
        {
            throw new NotImplementedException();
        }

        public void DeclarePredicate(string name, string alias, Expression expression)
        {
            throw new NotImplementedException();
        }

        public void DeclareTest(string name, Expression expression)
        {
            throw new NotImplementedException();
        }

        public void DeclareTest(string name, string alias, Expression expression)
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
