using System;
using System.Collections.Generic;
using SpecialCounter;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main(string[] args)
        {
            SpecialList specialList = new SpecialList
            {
                Max = 1000,
                CounterHighlights = new Dictionary<int, string>() {{5, "Fun"}, {6, "More Fun"}}
            };
            Dictionary<int, string> list = specialList.Generate();
            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();

        }
    }
}
