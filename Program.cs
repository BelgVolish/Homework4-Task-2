using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк матрицы: ");
            var rowCount = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы: ");
            var colCount = int.Parse(Console.ReadLine());

            var m1 = new int[rowCount, colCount];
            var m2 = new int[rowCount, colCount];

            var random = new Random();
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    m1[row, col] = random.Next(10);
                    m2[row, col] = random.Next(10);
                }
            }

            var m3 = new int[rowCount, colCount];
            var m4 = new int[rowCount, colCount];
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    m3[row, col] = m1[row, col] + m2[row, col];
                }
            }

            Console.WriteLine("\nСложение матриц:");
            for (var row = 0; row < rowCount; row++)
            {
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{m1[row, col]}\t");
                }
                Console.Write($"\t\t");
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{m2[row, col]}\t");
                }
                Console.Write($"\t\t");
                for (var col = 0; col < colCount; col++)
                {
                    Console.Write($"{m3[row, col]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}