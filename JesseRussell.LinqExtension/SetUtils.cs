using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    public static class SetUtils
    {
        public static void Refill<T>(this ISet<T> set, IEnumerable<T> collection)
        {
            set.Clear();
            foreach (T i in collection) set.Add(i);
        }
    }
}
