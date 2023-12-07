using System;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Server;


internal class Program
{
    public static void Main(string[] args)
    {
        /*Задание 1
        try
        {
            string[] words = File.ReadAllText("numsTask1.txt").Split(' ').ToArray();
        
            foreach (var word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
        */
        /* Задание 2
        try
        {
            string[] lines = File.ReadAllLines("numsTask2.txt");

            string result = string.Join(" ", lines);
            
            Console.WriteLine(result);
            
            File.WriteAllText("numsTask2result.txt", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occorred: {ex.Message}");
            throw;
        }
        */
        /* Задание 3
        Console.WriteLine("Введите число:");
        int num = Int32.Parse(Console.ReadLine());
        if (num % 10 == 0)
        {
            Console.WriteLine("Число четное и кратное 10");
        }
        else
        {
            Console.WriteLine("Число не четное и не кратное 10");
        }
        */
        /* Задание 4
        Console.WriteLine("Введите число a:");
        int a = Int32.Parse(Console.ReadLine());
        
        int sum = 0;
        
        Console.WriteLine("Введите число, при вводе отрицательного числа программа закончит работу: ");
        int num = Int32.Parse(Console.ReadLine());

        while(num >= 0)
        {
            Console.WriteLine("Введите число, при вводе отрицательного числа программа закончит работу: ");
            num = Int32.Parse(Console.ReadLine());
            if (num % a == 0)
            {
                sum += num;
            }
        }

        Console.WriteLine($"Сумма чисел, делящихся на положительное число a нацело: {sum}");
        */
        
        /* Задание 5
        Random random = new Random();
        Console.WriteLine("Введите количество строк матрицы:");
        int n = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество столбцов матрицы:");
        int m = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(0, 2);
            }
        }
        
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }

        int[,] newMatrix = new int[n, m + 1];
        int count = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                newMatrix[i, j] = matrix[i, j];
                if (matrix[i, j] == 1)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                newMatrix[i, n + 2] = 0;
            }
            else
            {
                newMatrix[i, n + 2] = 1;
            }

            count = 0;
        }
        
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write($"{newMatrix[i, j]} ");
            }
            Console.WriteLine();
        }

        */
        
        /* Задание 6
        Random random = new Random();
        Console.WriteLine("Введите размер массива: ");
        int n = Int32.Parse(Console.ReadLine());
        double[] array = new double[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-10000, 10000) / 100.0;
        }

        int negativeCount = 0;
        int positiveCount = 0;
        foreach (var num in array)
        {
            if (num >= 0)
            {
                positiveCount++;
            }
            else
            {
                negativeCount++;
            }
        }
        double[] negativeArray = new double[negativeCount];
        double[] positiveArray = new double[positiveCount];

        int j = 0;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] >= 0)
            {
                positiveArray[j] = array[i];
                j++;
            }
            else
            {
                negativeArray[k] = array[i];
                k++;
            }
        }
        
        Console.WriteLine("Исходный массив");
        foreach (var num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Массив с положительными элементами");
        foreach (var num in positiveArray)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Массив с отрицательными элементами");
        foreach (var num in negativeArray)
        {
            Console.Write($"{num} ");
        }
        */
    }
}