using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    abstract class Predicate
    {
        public static Predicate CreateAndRegister(string name)
        {
            throw new NotImplementedException();
        }

        public static Predicate CreateAndRegister(string name, string alias)
        {
            throw new NotImplementedException();
        }

        public static Predicate CreateAndRegister(string name, Expression expression)
        {
            throw new NotImplementedException();
        }

        public static Predicate CreateAndRegister(string name, string alias, Expression expression)
        {
            throw new NotImplementedException();
        }
    }
}
