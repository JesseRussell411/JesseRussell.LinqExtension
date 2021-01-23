using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    public static class SetUtils
    {
        public static void Fill<T>(this ISet<T> set, IEnumerable<T> collection) { foreach (T i in collection) set.Add(i); }

        public static void Refill<T>(this ISet<T> set, IEnumerable<T> collection)
        {
            set.Clear();
            set.Fill(collection);
        }
    }
}
