using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace split_by_word_casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            foreach (var word in words)
            {
                if(isLowerCase(word))
                {
                    lowerCase.Add(word);
                }
                else if(isUpperCase(word))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
        static bool isLowerCase(string word)
        {
            bool isLowerCase = true;
            foreach (char letter in word)
            {
                if(letter >= 'a' && letter <= 'z')
                {
                    isLowerCase = true;
                }
                else
                {
                    isLowerCase = false;
                    break;
                }
               
            }
            if (isLowerCase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool isUpperCase(string word)
        {
            bool isUpperCase = true;
            foreach (char letter in word)
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    isUpperCase = true;
                }
                else
                {
                    isUpperCase = false;
                    break;
                }

            }
            if (isUpperCase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
