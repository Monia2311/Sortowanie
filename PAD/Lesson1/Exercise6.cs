using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD.Lesson1
{
    internal class Exercise6
    {
        public int[] tablica = new int[10]; //public, żeby była dostępna własność Length dla tablicy w Program.cs
        public void WpiszTablice()
        {
            Console.WriteLine("\nTablice\n");

            for (int i = 0; i < tablica.Length; i++)
            {
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

        public void Merge(Exercise6 exercise6, int[] buf, int l, int r)
        {
            int i, j, m;
            m = (l + r) >> 1;
            i = l;
            j = m + 1;
            //łączenie do bufora dodatkowego
            for(int k=l; k<=r; k++)
            {
                if(i<=m)
                {
                    if(j<=r)
                    {
                        if (exercise6.tablica[i] < exercise6.tablica[j])
                        {
                            buf[k] = exercise6.tablica[i];
                            i++;
                        }
                        else
                        {
                            buf[k] = exercise6.tablica[j];
                            j++;
                        }
                    }
                    else
                    {
                        buf[k] = exercise6.tablica[i];
                        i++;
                    }
                }
                else
                {
                    buf[k] = exercise6.tablica[j];
                    j++;
                }
            }
            //przypisanie elementów do tablicy wejsciowej
            for(int k=l; k<=r;k++)
            {
                exercise6.tablica[k] = buf[k];
            }
        }
        public void MergeSort(Exercise6 exercise6, int[] buf, int l, int r)
        {
            int m;
            if (l < r)
            {
                // dokonanie podzialu
                m = (l + r) >> 1;
                MergeSort(exercise6, buf, l, m);
                MergeSort(exercise6, buf, m + 1, r);
                // zlaczanie posortowanych fragmentow
                Merge(exercise6, buf, l, r);
            }
        }

    }
}
