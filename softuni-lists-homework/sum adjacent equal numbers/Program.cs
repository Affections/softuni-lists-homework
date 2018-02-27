using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_adjacent_equal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i+1]<number.Count)
                   
                if(number[i] == number[i+1])
                {
                    number[i] += number[i + 1];
               number.RemoveAt(i + 1);
           
                    i = 0;
                    Console.WriteLine(string.Join(" ", number));
                }

            }
     
        }
    }
}
