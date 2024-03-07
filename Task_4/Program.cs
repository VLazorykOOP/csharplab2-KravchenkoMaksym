using System;


namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введiть кiлькiсть рядкiв (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введiть кiлькiсть елементiв у кожному рядку (m): ");
            int m = int.Parse(Console.ReadLine());

            // Створення східчастого масиву
            int[,] inputArray = new int[n, m];

            // Заповнення масиву з консолі
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введiть елементи для рядка {i + 1} (через пробiл): ");
                string[] inputValues = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    inputArray[i, j] = int.Parse(inputValues[j]);
                }
            }

            // Масив для зберігання результатів
            int[] resultArray = new int[n];

            // Знаходження номеру першого від'ємного елемента в кожному рядку
            for (int i = 0; i < n; i++)
            {
                resultArray[i] = FindFirstNegativeIndex(inputArray, i, m);
            }

            // Виведення результатів
            Console.WriteLine("Номери перших вiд'ємних елементiв у кожному рядку:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Рядок {i + 1}: {(resultArray[i] == -1 ? "Немає вiд'ємних елементiв" : resultArray[i].ToString())}");
            }
        }

        // Метод для знаходження номеру першого від'ємного елемента в рядку
        static int FindFirstNegativeIndex(int[,] array, int row, int length)
        {
            for (int j = 0; j < length; j++)
            {
                if (array[row, j] < 0)
                {
                    return j + 1; // Нумерація в масиві починається з 0, тому додаємо 1
                }
            }
            // Якщо від'ємних елементів немає, повертаємо -1
            return -1;
        }
    }
}
