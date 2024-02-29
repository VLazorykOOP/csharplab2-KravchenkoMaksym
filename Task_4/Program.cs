using System;


namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть кiлькiсть рядкiв: ");
            int n = int.Parse(Console.ReadLine());

            // Ініціалізуємо та вводимо східчастий масив
            int[][] jaggedArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введiть кiлькiсть елементiв у рядку {i + 1}: ");
                int m = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[m];

                Console.WriteLine($"Введiть елементи рядку {i + 1}:");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Елемент {j + 1}: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Знаходимо номери перших від'ємних елементів та записуємо дані у новий масив
            int[] resultArray = FindFirstNegativeElements(jaggedArray);

            // Виводимо результат
            Console.WriteLine("Номери перших вiд'ємних елементiв у кожному рядку:");
            PrintArray(resultArray);
        }

        static int[] FindFirstNegativeElements(int[][] arr)
        {
            int[] resultArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                resultArray[i] = -1; // За замовчуванням, якщо в рядку немає від'ємного елемента

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < 0)
                    {
                        resultArray[i] = j + 1; // Номер першого від'ємного елемента (індекс + 1)
                        break;
                    }
                }
            }

            return resultArray;
        }

        static void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
