using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "me", "you", "she" };
            string[] arr2 = { "he", "us", "they" };

            string[] arr3;

            arr3 = new string [arr1.Length + arr2.Length];

            int k = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[k++] = arr1[i];  
            }
            for (int j = 0; j <arr2.Length; j++)
            {
                arr3[k++] = arr2[j];
            }
            
            for (int a = 0; a < arr3.Length; a++)
            {
                Console.WriteLine(arr3[a]);
            }
            Console.ReadLine();

        }
    }
}
