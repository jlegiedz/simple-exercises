using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseInPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 6, 3, 9, 7, 4};

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]+" ");
            }

            Console.WriteLine();

            int n = (int)Math.Floor(num.Length / 2.0);

            int a;
            for (int i =0; i < n; i++)
            {
                a = num[i];
                num[i] = num[num.Length - i - 1];
                num[num.Length - i - 1] = a;

            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
