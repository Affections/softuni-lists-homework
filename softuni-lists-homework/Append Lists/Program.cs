using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> outerList = Console.ReadLine()
                  .Split('|')
                  .Reverse()
                  .Select(s => s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList())
                  .ToList();

            foreach (var innerList in outerList)
            {
                Console.WriteLine(string.Join(" ", innerList) + " ") ;
            }
        }
    }
}
