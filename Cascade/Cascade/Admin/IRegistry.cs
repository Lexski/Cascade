using System.Collections.Generic;

namespace Cascade.Admin
{
    // An interface through which classes can register objects under given names.
    interface IRegistry
    {
        // Registers a new object using its name. The object must implement INamed.
        void Register<T>(T thing) where T : INamed;

        // Registers an object with an alias.
        void Register<T>(T thing, string alias) where T : INamed;

        // Registers an object without using a name.
        void RegisterAnonymously<T>(T thing);

        // Checks if a particular object is already in the registry.
        bool HasObject<T>(T thing);

        // Checks if a particular alias is being used in the registry.
        bool IsAliasInUse(string alias);

        // Returns the object with the given alias.
        T GetObject<T>(string alias);

        // Returns a collection of all objects of the given type.
        ICollection<T> GetAll<T>();
    }
}
