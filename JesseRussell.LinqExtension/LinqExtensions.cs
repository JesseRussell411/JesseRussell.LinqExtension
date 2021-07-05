using System;
using System.Collections.Generic;
using System.Linq;

namespace JesseRussell.LinqExtension
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> stream, Action<T> action)
        {
            foreach(T item in stream)
            {
                action(item);
            }
        }

        public static void PrintSelf(this object self, Action<object> printFunction = null) => (printFunction ?? Console.WriteLine)(self);
    }
}
