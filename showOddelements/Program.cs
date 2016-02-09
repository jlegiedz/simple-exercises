using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showOddelements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = { "a", "b", "c", "d", "e", "f" };
          

            for (int i = 0; i < letters.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(letters[i]+" ");
                 
                }
            }
            Console.ReadLine();
        }
    }
}
