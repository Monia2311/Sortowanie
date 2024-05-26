using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise3
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

        public void BubbleSort()
        {
            int temporary = 0;
            
            for(int i = 0;i < tablica.Length-1;i++)
            {
                bool swapped = false;

                for(int j = 0;j < tablica.Length-1;j++)
                {
                    if (tablica[j] > tablica[j+1])
                    {
                        temporary = tablica[j + 1];
                        tablica[j+1] = tablica[j];
                        tablica[j] = temporary;
                        swapped = true;
                    }
                }

                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}
