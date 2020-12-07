using System;
using System.Linq;

using JesseRussell.LinqExtension;

namespace Debugging
{
    class Debugging
    {
        static void Main(string[] args)
        {
            Type[] ta = new Type[] { typeof(int), typeof(string), typeof(MonoEnu<int>)};
            Type[] ta = new TypeArray().ToArray();

            ITypeArray ita = new Type[] { typeof(int), typeof(double) }.ToTypeArray();
        }
    }
}
