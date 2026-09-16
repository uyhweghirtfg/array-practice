using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Создаём массив из 10 случайных чисел в диапазоне [1, 100]
        Random rnd = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 101); // 1..100 включительно
        }

        // 2. Вывод массива одной строкой
        Console.WriteLine("Массив: " + string.Join(", ", numbers));

        // 3. Сумма всех элементов
        long sum = 0;
        foreach (int n in numbers)
            sum += n;
        Console.WriteLine("Сумма: " + sum);

        // 4. Произведение всех элементов
        double product = 1;
        foreach (int n in numbers)
            product *= n;
        Console.WriteLine("Произведение: " + product);

        // 5. Количество чётных чисел
        int evenCount = 0;
        foreach (int n in numbers)
            if (n % 2 == 0) evenCount++;
        Console.WriteLine("Чётных чисел: " + evenCount);

        // 6. Среднее арифметическое и количество чисел больше среднего
        double average = (double)sum / numbers.Length;
        int greaterThanAvg = 0;
        foreach (int n in numbers)
            if (n > average) greaterThanAvg++;

        Console.WriteLine($"Больше среднего ({average:F1}): {greaterThanAvg}");
    }
}