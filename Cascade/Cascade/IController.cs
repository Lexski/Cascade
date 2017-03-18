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

        void DeclarePredicate(string name, string alias);

        void DeclarePredicate(string name, Expression expression);

        void DeclarePredicate(string name, string alias, Expression expression);

        void DeclareTest(string name, Expression expression);

        void DeclareTest(string name, string alias, Expression expression);

        void Assert(Formula formula);

        void Generate();

        void Save(string filePath);
    }
}
