using System.Collections;
using System.Collections.Generic;

namespace JesseRussell.LinqExtension
{
    /// <summary>
    /// An immutable enumerable struct that stores and enumerates over a single item.
    /// </summary>
    /// <typeparam name="T">The type of the item stored.</typeparam>
    public readonly struct MonoEnu<T> : IEnumerable<T>
    {
        /// <summary>
        /// The item stored
        /// </summary>
        public readonly T Value;

        public MonoEnu(T value) => Value = value;

        /// <summary>
        /// Returns an enumerator over the single item.
        /// </summary>
        public IEnumerator<T> GetEnumerator() { yield return Value; }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public static implicit operator T(MonoEnu<T> self) => self.Value;
        public static implicit operator MonoEnu<T>(T t) => new MonoEnu<T>(t);
    }
}
