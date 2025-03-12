using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_PenzesTibor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15];

            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1,101);
                Console.Write($"{a[i]},");
            }
            

            Console.ReadKey();
        }
    }
}
