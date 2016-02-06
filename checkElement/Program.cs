using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 8, 3, 4, 7, 6, 5 };

            int a = 1;
            
            for (int i = 0; i < arr.Length; i++)
            
            {
               if (arr[i] == a)
                {
                  
                    Console.WriteLine("The element you are looking for is in the list in " + i + " place");
                }
         
            }
            Console.ReadLine();
        }
    }
}
