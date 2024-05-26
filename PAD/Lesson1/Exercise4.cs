using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise4
    {
        int[] tablica = new int[10];
        public void WpiszTablice()
        {
            Console.WriteLine("\nTablice\n");

            for (int i = 0; i < tablica.Length; i++)
            {
                //tablica[i] = i;
                tablica[i] = int.Parse(Console.ReadLine());
            }
        }

        public void WypiszTablice()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("tablica[" + i + "]=" + tablica[i]);
            }
        }

        public void SelectionSort()
        {
            int temporary = 0;
            int min;

            for (int i = 0; i < tablica.Length - 1; i++)
            {
                min = i;

                for (int j = i+1; j < tablica.Length; j++)
                {
                    if (tablica[j] < tablica[min])
                    {
                        min = j;
                    }
                }

                temporary = tablica[i];
                tablica[i] = tablica[min];
                tablica[min]= temporary;
            }
        }
    }
}
