using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    public static class ListUtils
    {
        public static void Fill<T>(this IList<T> list, IEnumerable<T> collection) { foreach (T i in collection) list.Add(i); }

        public static void Refill<T>(this IList<T> list, IEnumerable<T> collection)
        {
            list.Clear();
            list.Fill(collection);
        }
    }
}
