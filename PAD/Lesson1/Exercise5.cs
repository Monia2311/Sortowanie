using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise5
    {
        int[] tablica = new int[5];
        public void WpiszTablice()
        {
            Console.WriteLine("\nTablice\n");

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write($"tablica[{i}]=");
                tablica[i] = int.Parse(Console.ReadLine());
            }
        }

        public void WypiszTablice()
        {
            //display
            foreach (var item in tablica)
            {
                Console.WriteLine("tablica[item]="+item);
            }
        }

        public void InsertionSort()
        {
            for (int i = 1; i < tablica.Length; i++)
            {
                int temporary = tablica[i];
                int j = i - 1;

                while ( j >= 0 && tablica[j] > temporary)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }
                tablica[j + 1] = temporary;
            }
        }
    }
}
