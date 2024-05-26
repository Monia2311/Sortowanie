using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise1
    {
        public static void Test()
        {
            Console.WriteLine("\nTablice\n");
            int[] tablica = new int[10];

            for (int i = 0; i < tablica.Length; i++)
            {
                //tablica[i] = i;
                tablica[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < tablica.Length; i++)
            {
                Console.WriteLine("tablica["+i+"]="+tablica[i]);
            }

            int max = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > max)
                    max = tablica[i];
            }
            Console.WriteLine($"Max = {max}");
        }
    }
}
