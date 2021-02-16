using System;
using System.Collections.Generic;

namespace No_Sense_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string list = Console.ReadLine();
            string[] ints = list.Split(",");
            List<int> ls = new List<int>();
            foreach (var item in ints)
            {
                int intValue = int.TryParse(item, out intValue) ? intValue : 0;
                ls.Add(intValue);
            }
            ls = (List<int>)ls.ThisDoesntMakeAnySense(o => o > 50, () => new List<int>() { 1, 2, 3, 4 });
            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
