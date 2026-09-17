using System;

class Program
{
    static void Main()
    {
        // 1. Запрос количества элементов с проверкой N > 0
        int n;
        while (true)
        {
            Console.Write("Введите количество элементов: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                    break;
                Console.WriteLine("Ошибка: N должно быть больше 0. Попробуйте снова.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое.");
            }
        }

        // 2. Заполнение массива с клавиатуры с обработкой исключений
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Элемент [{i}]: ");
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    break; // успешно — выходим из while
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число выходит за пределы типа int.");
                }
            }
        }

        Console.WriteLine();

        // 3. Исходный массив
        Console.WriteLine("Исходный массив:  " + string.Join(", ", numbers));

        // 4. Обратный порядок
        int[] reversed = new int[n];
        for (int i = 0; i < n; i++)
        {
            reversed[i] = numbers[n - 1 - i];
        }
        Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

        // 5. Сортировка по возрастанию
        int[] sorted = (int[])numbers.Clone(); // копия, чтобы не портить исходный
        Array.Sort(sorted);
        Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

        // 6. Максимум и минимум без LINQ
        int max = numbers[0];
        int min = numbers[0];
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] > max) max = numbers[i];
            if (numbers[i] < min) min = numbers[i];
        }
        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}