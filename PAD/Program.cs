// See https://aka.ms/new-console-template for more information
using PAD.Lesson1;

Console.WriteLine("Hello, World!");
//Exercise1.Test();

//Exercise2 exercise2 = new Exercise2();
//exercise2.WpiszTablice();
//exercise2.WypiszTablice();
//exercise2.Max();

//Exercise3 exercise3 = new Exercise3();
//exercise3.WpiszTablice();
//exercise3.WypiszTablice();
//exercise3.BubbleSort();
//Console.WriteLine("\nPo sortowaniu:");
//exercise3.WypiszTablice();

//Exercise4 exercise4 = new Exercise4();
//exercise4.WpiszTablice();
//exercise4.WypiszTablice();
//exercise4.SelectionSort();
//Console.WriteLine("\nPo sortowaniu:");
//exercise4.WypiszTablice();

//Exercise5 exercise5 = new Exercise5();
//exercise5.WpiszTablice();
//Console.WriteLine("\nPrzed sortowaniu:");
//exercise5.WypiszTablice();
//exercise5.InsertionSort();
//Console.WriteLine("\nPo sortowaniu:");
//exercise5.WypiszTablice();

//int[] bufor = new int[10];
//Exercise6 exercise6 = new Exercise6();
//exercise6.WpiszTablice();
//int l = 0;
//int r = exercise6.tablica.Length - 1;
//Console.WriteLine("\nPrzed sortowaniu:");
//exercise6.WypiszTablice();
//exercise6.MergeSort(exercise6, bufor, l, r);
//Console.WriteLine("\nPo sortowaniu:");
//exercise6.WypiszTablice();

Exercise7 exercise7 = new Exercise7();
exercise7.LosujTablice();
Console.WriteLine("\nPrzed sortowaniu:");
exercise7.WypiszTablice();
int l = 0;
int r = exercise7.tablica.Length - 1;
exercise7.QuickSort(exercise7,l,r);
Console.WriteLine("\nPo sortowaniu:");
exercise7.WypiszTablice();