using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domains = new Dictionary<string, string>
            {
                
                {"est", "estonia"},
                {"lat", "latvia" },
                {"fin", "finland" },
                {"swe", "sweden" },

            };
            int i = 1;
            foreach (var pair in domains)
            {
                Console.WriteLine($"{pair.Value} - {pair.Key} - {i}");
                i++;
            }
        }
    }
}
