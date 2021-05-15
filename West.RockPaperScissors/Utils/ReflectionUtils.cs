using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace West.RockPaperScissors.Utils
{
    public static class ReflectionUtils
    {
        public static IEnumerable<Type> GetEnumerableOfType<T>() where T : class//, IComparable<T>
        {
            List<Type> objects = new List<Type>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add(type);
            }
            return objects;
        }
        
        public static T Activate<T>(Type type)
        {
            return (T)Activator.CreateInstance(type);
        }
    }
}
