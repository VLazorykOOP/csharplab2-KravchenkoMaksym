using System;


namespace Task_1
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Виберiть тип масиву (1 - одновимiрний, 2 - двовимiрний): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    OneDimensionalArray();
                    break;

                case 2:
                    TwoDimensionalArray();
                    break;

                default:
                    Console.WriteLine("Невiрний вибiр.");
                    break;
            }
        }

        static void OneDimensionalArray()
        {
            Console.Write("Введiть розмiрнiсть масиву: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Введiть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 9 == 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Сума елементiв, кратних 9: {sum}");
        }

        static void TwoDimensionalArray()
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть стовпцiв: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, cols];

            Console.WriteLine("Введiть елементи масиву:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 9 == 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine($"Сума елементiв, кратних 9: {sum}");
        }
    }
}
