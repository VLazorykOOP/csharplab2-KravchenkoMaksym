using System;


namespace Task_3
{
    internal class Program
    {
        static void Main()
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

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            if (cols % 2 == 0)
            {
                SwapColumns(array);
                Console.WriteLine("Масив пiсля змiни стовпцiв:");
                PrintArray(array);
            }
            else
            {
                Console.WriteLine("Кiлькiсть стовпцiв непарна, залишаємо масив без змiн.");
            }
        }

        static void SwapColumns(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j += 2)
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                }
            }
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}

