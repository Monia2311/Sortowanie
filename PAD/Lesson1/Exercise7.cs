using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise7
    {
        public int[] tablica = new int[20];
        public void LosujTablice()
        {
            Console.WriteLine("\nTablica losowa:\n");

            Random r = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
               // Console.Write($"tablica[{i}]=");
                tablica[i] = r.Next(53,200);
                //Console.WriteLine();
            }
        }

        public void WypiszTablice()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("tablica[" + i + "]=" + tablica[i]);
            }
        }

        public void Swap(Exercise7 ex, int i, int j)
        {
            int t;
            t = ex.tablica[i];
            ex.tablica[i] = ex.tablica[j];
            ex.tablica[j] = t;
        }

        public int Partition(Exercise7 ex, int l, int r)
        {
            int p, t;
            int j, v;
            v = (l + r) >> 1;
            p = ex.tablica[v];      // podzial wg wartosci pierwszego elementu tablicy
            Swap(ex, v, r);     // element podzialu zamieniany z ostatnim elementem
            j = l;
            for (int i = l; i < r; i++)
            {
                if (ex.tablica[i] < p)
                {
                    Swap(ex, i, j);
                    j = j + 1;
                }
            }
            Swap(ex, j, r); // przywrocenie elementu podzialu na wlasciwe miejsce
            return j;
        }

        public void QuickSort(Exercise7 ex, int l, int r)
        {
            int i;
            if (l < r)
            {
                i = Partition(ex, l, r); // indeks podzialu
                QuickSort(ex, l, i - 1); // sortowanie lewej czesci tablicy
                QuickSort(ex, i + 1, r); // sortowanie prawej czesci tablicy
            }
        }
    }
}
