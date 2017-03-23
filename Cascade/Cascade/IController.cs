using Cascade.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade
{
    // Represents something that implements Cascade commands.
    interface IController
    {
        void DeclarePredicate(string name);

        void DeclarePredicateWithAlias(string name, string alias);

        void DeclarePredicateByExpression(string name, string expressionString);

        void DeclarePredicateWithAliasByExpression(string name, string alias, string expressionString);

        void DeclareTest(string name, string expressionString);

        void DeclareTestWithAlias(string name, string alias, string expressionString);

        void Assert(string ruleString);

        void Generate();

        void Save(string filePath);
    }
}
