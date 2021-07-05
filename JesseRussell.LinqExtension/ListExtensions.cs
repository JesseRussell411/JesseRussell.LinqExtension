using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    public static class ListExtensions
    {
        public static void Fill<T>(this IList<T> list, IEnumerable<T> content) { foreach (T i in content) list.Add(i); }

        public static void Refill<T>(this IList<T> list, IEnumerable<T> content)
        {
            list.Clear();
            list.Fill(content);
        }

    }
}
