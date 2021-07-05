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

            s.DoToSelves(c => { cCount.EnsureKey(c, 0); cCount[c]++; });
            cCount.OrderBy(p => p.Key).DoToSelves(p => $"{p.Key} {p.Value}".PrintSelf());


            void doNothing(char c) { }
            'a'.DoToSelf(doNothing).PrintSelf();

            //foreach (char c in s)
            //{
            //    cCount.EnsureKey(c, 0);
            //    cCount[c]++;
            //}

            //Console.WriteLine(
            //    cCount.OrderBy(p => p.Key).Select(p => $"{p.Key} {p.Value}").Aggregate((t, c) => $"{t}\n{c}")
            //    );

            //Dictionary<char, int> test = new Dictionary<char, int>();
            //test.Add('\t', 999999999);
            //test.Fill(cCount);

            //Console.WriteLine(
            //    test.OrderBy(p => p.Key).Select(p => $"{p.Key} {p.Value}").Aggregate((t, c) => $"{t}\n{c}")
            //    );

            //test.Refill(cCount);

            //Console.WriteLine(
            //    test.OrderBy(p => p.Key).Select(p => $"{p.Key} {p.Value}").Aggregate((t, c) => $"{t}\n{c}")
            //    );
        }
    }
}
