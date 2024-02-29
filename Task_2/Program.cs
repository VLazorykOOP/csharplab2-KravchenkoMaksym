using System;


namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введiть розмiрнiсть масиву: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            Console.WriteLine("Введiть послiдовнiсть чисел:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            int maxIndex = FindIndexOfMaxElement(array);

            Console.WriteLine($"Номер першого максимального елемента: {maxIndex + 1}");
        }

        static int FindIndexOfMaxElement(double[] arr)
        {
            double maxElement = arr[0];
            int maxIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
