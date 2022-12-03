using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 4, 7, 2 },
                         { 5, 9, 2, 3 },
                         { 8, 4, 2, 4 } };

            Console.WriteLine();
            int n = -1;
            int mn = 0, s;
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                s = 0;
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write("{0,5}", a[i, j]);
                    s += a[i, j];
                }
                Console.WriteLine();
                if (n < 0 || s < mn)
                {
                    mn = s;
                    n = i;
                }
            }            
            Console.WriteLine("\n{0} строка", n + 1);            

            Console.ReadKey();
        }
    }
}
