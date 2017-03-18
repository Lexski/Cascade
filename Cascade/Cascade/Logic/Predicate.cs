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
        public Predicate(string name)
        {
            Name = name;
        }

        public static void CreateAndRegister(string name, IRegistry registry)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            else if (registry == null)
            {
                throw new ArgumentNullException("registry");
            }
            else
            {
                ElementaryPredicate elementaryPredicate = new ElementaryPredicate(name);
                registry.Register(elementaryPredicate);
            }
        }

        public static void CreateAndRegister(string name, string alias, IRegistry registry)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            else if (alias == null)
            {
                throw new ArgumentNullException("alias");
            }
            else if (registry == null)
            {
                throw new ArgumentNullException("registry");
            }
            else
            {
                ElementaryPredicate elementaryPredicate = new ElementaryPredicate(name);
                registry.Register(elementaryPredicate, alias);
            }
        }

        public static void CreateAndRegister(string name, Expression expression, IRegistry registry)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            else if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }
            else if (registry == null)
            {
                throw new ArgumentNullException("registry");
            }
            else
            {
                DerivedPredicate derivedPredicate = new DerivedPredicate(name, expression);
                registry.Register(derivedPredicate);
            }
        }

        public static void CreateAndRegister(string name, string alias, Expression expression, IRegistry registry)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            else if (alias == null)
            {
                throw new ArgumentNullException("alias");
            }
            else if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }
            else if (registry == null)
            {
                throw new ArgumentNullException("registry");
            }
            else
            {
                DerivedPredicate derivedPredicate = new DerivedPredicate(name, expression);
                registry.Register(derivedPredicate, alias);
            }
        }

        public string Name { get; }
    }
}
