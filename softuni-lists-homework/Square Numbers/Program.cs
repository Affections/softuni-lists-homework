using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>(numbers.Count);
            foreach (var item in numbers)
            {
                var sqrt = Math.Sqrt(item);
                if (sqrt == (int)sqrt)
                {
                    output.Add(item);
                }
            }
            output.Sort();
            output.Reverse();
            Console.WriteLine(string.Join(" ",output));
       
        
        }
    }
}
