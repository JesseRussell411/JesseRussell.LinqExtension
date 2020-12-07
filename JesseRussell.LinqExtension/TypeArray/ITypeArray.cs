using System;
using System.Collections.Generic;
using System.Text;

namespace JesseRussell.LinqExtension
{
    /// <summary>
    /// Represents an indexable and enumerable array of Types.
    /// </summary>
    public interface ITypeArray : IEnumerable<Type>
    {
        Type this[int i] { get; }
        /// <summary>
        /// The number of items in the type array.
        /// </summary>
        int Length { get; }
    }
}
