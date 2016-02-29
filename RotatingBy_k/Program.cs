using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotatingBy_k
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, };

            rotate_k(num, 3);
            

        }

        static void rotate_k(int[] num, int k)
        {
            for ( int i = 0; i < k; i++)
            {
                rotate(num);
            }
        }

        static void rotate(int[] num)
        {
            int a = num[0];
            for (int i = 0; i<num.Length -1; i++)
            {
                num[i] = num[i + 1];
            }

            num[num.Length - 1] = a;
        }   
        

    }
}
