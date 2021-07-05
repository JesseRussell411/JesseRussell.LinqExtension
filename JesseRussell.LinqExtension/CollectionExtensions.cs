using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    public static class CollectionExtensions
    {
        public static void Fill<T>(this ICollection<T> collection, IEnumerable<T> content) { foreach (T i in content) collection.Add(i); }

        public static void Refill<T>(this ICollection<T> collection, IEnumerable<T> content)
        {
            collection.Clear();
            collection.Fill(content);
        }
    }
}
