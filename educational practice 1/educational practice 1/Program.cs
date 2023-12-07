using System;
using System.Collections.Generic;
using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        /* ЗАДАНИЕ 1
        Random random = new Random();
        
        int[] nums = new int[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = random.Next(1, 1000);
        }

        int minIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[minIndex])
            {
                minIndex = i;
            }
        }

        Console.WriteLine($"Номер минимального элемента: {minIndex}");
        */

        /* Задание 2
        List<int> nums = new List<int>();
        int input;
        do
        {
            Console.WriteLine("Введите число (введите 0 для завершения): ");
            if (int.TryParse(Console.ReadLine(), out input) && input != 0)
            {
                nums.Add(input);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        } while (input != 0);

        int sum = 0;
        int product = 1;

        foreach (int i in nums)
        {
            sum += i;
            product *= i;
        }

        int average = sum / nums.Count;
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Среднее: {average}");
        */

        /* Задание 3
        List<string> array = new List<string>();
        string input;
        do
        {
            Console.WriteLine("Введите число (введите пустую строку для завершения): ");
            input = Console.ReadLine();
            if (input != "")
            {
                array.Add(input);
            }
        } while (input != "");

        int minStr = 0;
        int maxStr = 0;
        for (int i = 1; i < array.Count; i++)
        {
            if (array[i].Length < array[minStr].Length)
            {
                minStr = i;
            }

            if (array[i].Length > array[maxStr].Length)
            {
                maxStr = i;
            }
        }

        Console.WriteLine($"Самый короткий элемент списка: {array[minStr]}");
        Console.WriteLine($"Самый длинный элемент списка: {array[maxStr]}");
        */

        /* ЗАДАНИЕ 4
        Console.WriteLine("Введите начало диапазона: ");
        int startRange = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите конец диапазона: ");
        int endRange = int.Parse(Console.ReadLine());

        List<int> randomNums = GenerateRandomNums(startRange, endRange);
        
        Console.Write("Элементы массива: ");
        foreach (var i in randomNums)
        {
            Console.Write($"{i} ");
        }
    }


    static List<int> GenerateRandomNums(int startRange, int endRange)
    {
        List<int> randomNums = new List<int>();
        Random random = new Random();

        int amountElements = 10;
        for (int i = 0; i < amountElements; i++)
        {
            int randomNum = random.Next(startRange, endRange + 1); 
            randomNums.Add(randomNum);
        }

    return randomNums;
  */
      /* Задание 5
        Console.WriteLine("Введите строку: ");
        string str = Console.ReadLine();

        int wordCount = 0;

        string[] words = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        wordCount = words.Length;

        string newStr = $"Start {str} End";
        Console.WriteLine($"Количество слов в строке: {wordCount}");
        Console.WriteLine($"Измененная строка: {newStr}");
        */
    }
}
