using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JesseRussell.LinqExtension
{
    /// <summary>
    /// immutable TypeArray of arbitrary size.
    /// </summary>
    public class BigTypeArray : ITypeArray
    {
        public BigTypeArray(IEnumerable<Type> items) => this.items = items.ToArray();
        public BigTypeArray() => this.items = new Type[0];
        internal BigTypeArray(Type[] items) => this.items = items;

        private readonly Type[] items;
        public Type this[int i] => items[i];

        public int Length => items.Length;

        public IEnumerator<Type> GetEnumerator()
        {
            foreach(Type t in items)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }
}
