using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cascade.Admin;

namespace Cascade.Logic
{
    abstract class Predicate : INamed
    {
        public static Predicate CreateAndRegister(string name, IRegistry registry)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static Predicate CreateAndRegister(string name, string alias, IRegistry registry)
        {
            throw new NotImplementedException();
        }

        public static Predicate CreateAndRegister(string name, Expression expression, IRegistry registry)
        {
            throw new NotImplementedException();
        }

        public static Predicate CreateAndRegister(string name, string alias, Expression expression, IRegistry registry)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
    }
}
