using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeWaysSUm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] num = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };


            int add = 0;
             for (int i = 0; i < num.Length; i ++)
             {
                 add = i + add;

             }*/
            /*int i = 0;
            while ( i < num.Length)
                {
                add = i + add;
                i++;
                }
               Console.Write(add);
            Console.ReadLine();    
            
            */

            int[] num = { 1, 2, 3, 4, 5 };
            int result = num_sum(num, num.Length-1);
            Console.WriteLine(result);
            Console.ReadLine();
        }


            static int num_sum(int[] num, int n)
            {
                if (n == 0)
                {
                return num[0];
                }
                else
                {
                  return num[n] + num_sum(num, n - 1);
                } 
            }

    }
}
