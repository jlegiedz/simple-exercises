using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr2 = "kobylamamalybok";

            int n = (int)Math.Floor((decimal)arr2.Length / 2);

            bool isPalindrom = true;

            for (int i = 0; i < n; i ++)
            {
                if (arr2[i] != arr2[arr2.Length-1-i])
                {
                    isPalindrom = false;
                    break;
                }

            }
            if (isPalindrom)
            {
                Console.WriteLine(arr2 + " is a palindrome");
            }
            else
            {
                Console.WriteLine(arr2 + " is not a palindrome");
            }
            Console.ReadLine();

        }
    }
}
