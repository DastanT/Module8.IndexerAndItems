using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8.IndexerAndItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            IndexerArray indexerArray = new IndexerArray(size);
            Console.WriteLine("Размер массива = " + indexerArray.length);
            for (int i = 0; i < indexerArray.length; i++)
            {
                indexerArray[i] = rnd.Next(1, 20);
            }
            Console.WriteLine();

            Console.WriteLine("Весь массив: ");
            for (int i = 0; i < indexerArray.length; i++)
            {
                Console.WriteLine("array " + "[" + i + "]" + " = " + indexerArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Элемент массива в степени 2:");
            indexerArray.ArrayInSquare();
            Console.WriteLine();

            Console.WriteLine("Обращаемся к массиву по индексу.");
            Console.WriteLine("array [" + 0 +"] = " + indexerArray[0]);
            Console.WriteLine("array [" + 1 + "] = " + indexerArray[1]);
            Console.WriteLine("array [" + 2 + "] = " + indexerArray[2]);
            Console.WriteLine("array [" + 3 + "] = " + indexerArray[3]);


        }
    }
}
