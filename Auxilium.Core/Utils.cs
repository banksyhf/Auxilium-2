using System;
using System.Collections.Generic;
using System.Reflection;

namespace Auxilium.Core
{
    internal static class Utils
    {
        public static Type[] GetTypesInNamespace(string nameSpace)
        {
            List<Type> types = new List<Type>();

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (type.Namespace != null && type.Namespace.Contains(nameSpace) && type.IsPublic)
                    types.Add(type);

            return types.ToArray();
        }
    }
}
