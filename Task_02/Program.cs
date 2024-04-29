using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        int[] array = new int[5];
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            array[i] = random.Next(1, 10);
            Console.WriteLine(array[i] + " ");
        }

        int max = array.Max(); 

        int min = array.Min();

        int sum = array.Sum();

        double average = array.Average();

        // Виведення результатів
        Console.WriteLine($"\nНайбільше значення: {max}");
        Console.WriteLine($"Найменше значення: {min}");
        Console.WriteLine($"Загальна сума елементів: {sum}");
        Console.WriteLine($"Середнє арифметичне: {average:F2}");

        Console.WriteLine("\nНепарні значення: ");
        foreach (var item in array)
        {
            if (item % 2 != 0)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
