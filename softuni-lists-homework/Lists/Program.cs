using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.RemoveAll(x => x < 0);
            list.Reverse();
         
          if(list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else Console.WriteLine(string.Join(" ", list));

        }
    }
}
