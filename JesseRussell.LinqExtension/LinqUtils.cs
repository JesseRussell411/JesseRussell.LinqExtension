using System;
using System.Collections.Generic;
using System.Linq;

namespace JesseRussell.LinqExtension
{
    public static class LinqUtils
    {
        public static IEnumerable<T> Enumerate<T>(this T item) => new MonoEnu<T>(item);
        public static IEnumerable<Type> GetParents(this Type self) => self.BaseType.Enumerate().Concat(self.GetInterfaces());
        public static IEnumerable<Type> GetSelfAndParents(this Type self) => self.Enumerate().Concat(self.GetParents());
        public static ITypeArray ToTypeArray(this IEnumerable<Type> self) => new BigTypeArray(self.ToArray());
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> stream) => new HashSet<T>(stream);
        public static SortedSet<T> ToSortedSet<T>(this IEnumerable<T> stream) => new SortedSet<T>(stream);
        public static void DoOntoSelf<T>(this T self, Action<T> action = null) { if (action != null) action(self); }
        public static R DoOntoSelf<T, R>(this T self, Func<T, R> func) { if (func != null) return func(self); else return default(R); }
        public static void PrintSelf(this object self, Action<object> printFunction = null) => self.DoOntoSelf(printFunction ?? Console.WriteLine);
    }
}
