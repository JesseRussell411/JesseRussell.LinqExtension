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

            ITypeArray ita = new Type[] { typeof(int), typeof(double) }.ToTypeArray();
            ita = new BigTypeArray();

            Type[] tb = ita.ToArray();
            Console.WriteLine(tb.Length);
        }
    }
}
