using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a tömb n értékét");
            int n=int.Parse(Console.ReadLine());
            int[,] tomb=new int[n,n];
            Random rand=new Random();
            int osszeg = 0;
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                
                
                
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = rand.Next(-20, 21);
                    Console.Write($"{tomb[i, j],5}");
                    //osszeg+=tomb[i];(?)
                }
                
               
                Console.WriteLine($" | Sor összeg: {osszeg}");
            }


            Console.ReadKey();
        }
    }
}
