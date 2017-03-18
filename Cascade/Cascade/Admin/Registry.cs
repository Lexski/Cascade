using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.Admin
{
    class Registry : IRegistry
    {
        private HashSet<string> _objectAliases;

        private Dictionary<string, Tuple<Type, object>> _objectsByAlias;

        private Dictionary<Type, HashSet<object>> _objectsByType;

        public Registry()
        {
            _objectAliases = new HashSet<string>();
            _objectsByAlias = new Dictionary<string, Tuple<Type, object>>();
            _objectsByType = new Dictionary<Type, HashSet<object>>();
        }

        public void Register<T>(T thing) where T : INamed
        {
            if (thing == null)
            {
                throw new ArgumentNullException();
            }
            else if (thing.Name == null)
            {
                throw new ArgumentNullException();
            }
            else if (IsAliasInUse(thing.Name))
            {
                throw new InvalidOperationException($"An object called {thing.Name} already exists.");
            }
            else if (HasObject(thing))
            {
                throw new InvalidOperationException($"This object is already registered.");
            }
            else
            {
                _objectAliases.Add(thing.Name);
                _objectsByAlias.Add(thing.Name, Tuple.Create(thing.GetType(), (object)thing));
                AddObjectByType(thing);
            }
        }

        public void Register<T>(T thing, string alias) where T : INamed
        {
            if (thing == null)
            {
                throw new ArgumentNullException();
            }
            else if (thing.Name == null)
            {
                throw new ArgumentNullException("thing");
            }
            else if (alias == null)
            {
                throw new ArgumentNullException("alias");
            }
            else if (IsAliasInUse(thing.Name))
            {
                throw new InvalidOperationException($"An object called {thing.Name} already exists.");
            }
            else if (IsAliasInUse(alias))
            {
                throw new InvalidOperationException($"An object called {alias} already exists.");
            }
            else if (HasObject(thing))
            {
                throw new InvalidOperationException($"This object is already registered.");
            }
            else
            {
                _objectAliases.Add(thing.Name);
                _objectAliases.Add(alias);
                _objectsByAlias.Add(thing.Name, Tuple.Create(thing.GetType(), (object)thing));
                _objectsByAlias.Add(alias, Tuple.Create(thing.GetType(), (object)thing));
                AddObjectByType(thing);
            }
        }

        public void RegisterAnonymously<T>(T thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException();
            }
            else if (HasObject(thing))
            {
                throw new InvalidOperationException($"This object is already registered.");
            }
            else
            {
                AddObjectByType(thing);
            }
        }

        public bool HasObject<T>(T thing)
        {
            if (thing == null)
            {
                throw new ArgumentNullException();
            }
            else if (!_objectsByType.ContainsKey(thing.GetType()))
            {
                return false;
            }
            else
            {
                return _objectsByType[thing.GetType()].Contains(thing);
            }
        }

        public bool IsAliasInUse(string alias)
        {
            if (alias == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                return _objectAliases.Contains(alias);
            }
        }

        public T GetObject<T>(string alias)
        {
            if (alias == null)
            {
                throw new ArgumentNullException();
            }
            else if (!IsAliasInUse(alias))
            {
                throw new InvalidOperationException($"No object called {alias} exists.");
            }
            else if (typeof(T) != _objectsByAlias[alias].Item1)
            {
                throw new InvalidOperationException($"No object of type {typeof(T)} called {alias} exists.");
            }
            else
            {
                return (T)_objectsByAlias[alias].Item2;
            }
        }

        public ICollection<T> GetAll<T>()
        {
            if (!_objectsByType.ContainsKey(typeof(T)))
            {
                return new Collection<T>();
            }
            else
            {
                Collection<T> result = new Collection<T>();
                foreach (object thing in _objectsByType[typeof(T)])
                {
                    result.Add((T)thing);
                }

                return result;
            }
        }

        private void AddObjectByType<T>(T thing)
        {
            if (!_objectsByType.ContainsKey(thing.GetType()))
            {
                _objectsByType.Add(thing.GetType(), new HashSet<object>());
            }

            _objectsByType[thing.GetType()].Add(thing);
        }
    }
}

// ToDo: Add comments!