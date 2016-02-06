using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            var b = new ArrayList(a);

            int n = 30;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
            {
                for (int j = 1; j< n-1; j++)
                {
                    if (b[j] != null)
                    {
                        int c = (int)b[j];
                        

                        if (c % i == 0) 
                        {
                            if (c > i)
                            {
                                b[j] = null;
                            }
                        }
                    }
                }
            }
            foreach (object obj in b)
            {
                if (obj != null)
                {
                    int d = (int)obj;
                    Console.Write(d.ToString("00 "));
                }
            }
            Console.ReadLine();
        }
    }
}
