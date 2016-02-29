using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concSwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "1", "2", "3" };
            string[] arr2 = { "a", "b", "c" };

            string[] arr3 = new string [arr1.Length + arr2.Length];

            int n = arr1.Length;

            for (int i = 0; i < n; i++)
            {
                var j = i * 2;
                arr3[j] = arr1[i];
                arr3[j + 1] = arr2[i];
            }

             
            for (int a = 0; a < arr3.Length; a++)
            {
                Console.WriteLine(arr3[a]);

            }
            Console.ReadLine();
        }
    }
}
