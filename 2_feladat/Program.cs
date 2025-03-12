using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a tömb hosszát: ");
            int n=int.Parse(Console.ReadLine());
            int[] a =new int[n];
            Console.WriteLine();

            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(50,151);
            }

            foreach (var elem in a)
            {
                Console.Write($"{elem} ");
                
            }
            Console.WriteLine();

            Console.WriteLine($"Legnagyobb szám a tömbben: {a.Max()}");
            Console.WriteLine($"Legkissebb szám a tömbben: {a.Min()}");
            Console.WriteLine();

            //Hibás
            Console.WriteLine("A tömb csökkenő sorrendben: ");
            foreach (var elem in a)
            {
                Array.Sort(a);
                Console.Write($"{elem} ");
            }


            Console.ReadKey();
        }
    }
}
