using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runningTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;

            for (int i = 0; i <= num.Length; i++)
            {
                sum = sum + i;
               
            }
            Console.Write(sum);
            Console.ReadLine();
        }
     
    }
}
