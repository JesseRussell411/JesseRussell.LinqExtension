using System.Collections.Generic;
using System.Linq;
using System;

using JesseRussell.LinqExtension;

namespace Debugging
{
    class Debugging
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> cCount = new Dictionary<char, int>();

            string s = "the quick brown fox jumps over the lazy dog";


            foreach(char c in s)
            {
                cCount.EnsureKey(c, 0);
                cCount[c]++;
            }

            Console.WriteLine(
                cCount.OrderBy(p => p.Key).Select(p => $"{p.Key} {p.Value}").Aggregate((t, c) => $"{t}\n{c}")
                );
        }
    }
}
