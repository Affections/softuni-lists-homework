using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 != numbers.Count)
                {
                    while (numbers[i] == numbers[i + 1])
                    {
                        count++;
                        i++;
                        if (i + 1 != numbers.Count)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", numbers[i] + $" -> {count}"));
                            count = 1;
                            return;
                        }
                        }
                }
                else return;
                Console.WriteLine(string.Join("", numbers[i] + $" -> {count}"));
                count = 1;


            }
        }
    }
}
