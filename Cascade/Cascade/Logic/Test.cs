using Cascade.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Logic
{
    class Test : INamed
    {
        public static void CreateAndRegister(string name, Expression expression, IRegistry registry)
        {
            throw new NotImplementedException();
        }

        public static void CreateAndRegister(string name, string alias, Expression expression, IRegistry registry)
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
    }
}
