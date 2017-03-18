using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Admin
{
    class Registry : IRegistry
    {
        public void Register<T>(T thing) where T : INamed
        {
            throw new NotImplementedException();
        }

        public void Register<T>(T thing, string alias) where T : INamed
        {
            throw new NotImplementedException();
        }

        public void RegisterAnonymously<T>(T thing)
        {
            throw new NotImplementedException();
        }

        public bool HasObject<T>(T thing)
        {
            throw new NotImplementedException();
        }

        public bool IsAliasInUse(string alias)
        {
            throw new NotImplementedException();
        }

        public T GetObject<T>(string alias)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}
