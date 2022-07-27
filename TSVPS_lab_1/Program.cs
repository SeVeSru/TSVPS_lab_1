using System;

namespace TSVPS_lab_1
{
    internal class Program
    {
        static int Count = 10;
        static int[] Num = new int[10] {49, 12, 27, 4, 19, 37, 26, 11, 25, 8};

        static void selectionSort(int[] data)
        {
            for (int i = 0; i < Count; i++)
            {
                int j = i;
                for (int k = i+1; k < Count; k++)
                {
                    if (data[j] > data[k])
                    {
                        j = k;
                    }
                }
                Console.WriteLine($"Меняем элементы с индексом: [{i}]={data[i]} -> [{j}]={data[j]}");
                int tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;

            }
        }

        static void Main(string[] args)
        {
            Console.Write("Набор чисел: ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write(Num[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSelect сортировка: ");

            selectionSort(Num);

            Console.Write("Отсортированный массив: ");
            for (int j = 0; j < Count; j++)
            {
                Console.Write(Num[j] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
