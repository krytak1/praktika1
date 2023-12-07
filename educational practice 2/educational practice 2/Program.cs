using System;
using System.Collections.Generic;
using System.Data;


internal class Program
{
    public static void Main(string[] args)
    {
        /* Задание 1
        int[] nums = new int[100];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = (nums.Length * 3) - (i * 3);
        }
        */
        /* Задание 2
        Console.WriteLine("Введите размер массива: ");
        int n = Int32.Parse(Console.ReadLine());

        int[] nums = new int[n];
        int j = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = j;
            j += 2;
        }
        */
        /* Задание 3
        Console.WriteLine("Введите размер матрицы: ");
        int n = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            matrix[0, i] = 1;
            matrix[i, 0] = 1;
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        */
        /* Задание 4
        Random random = new Random();
        int[,] temperatures = new int[12, 30];

        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperatures[month, day] = random.Next(-20, 30);
            }
        }

        Console.WriteLine("Температура по месяцам:");
        
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Месяц {month + 1}:");
            for (int day = 0; day < 30; day++)
            {
                Console.Write(temperatures[month, day] + "\t");
            }

            Console.WriteLine();
        }

        double[] averageTemperatures = calculateAverageTemperatures(temperatures);

        Console.WriteLine("\nСредние температуру по месяцам");
        printAverageTemperatures(averageTemperatures);

        Array.Sort(averageTemperatures);

        Console.WriteLine("\nОтсортированные средние температуры");
        printAverageTemperatures(averageTemperatures);
    }

    static double[] calculateAverageTemperatures(int[,] temperatures)
    {
        double[] averageTemperatures = new double[12];

        for (int month = 0; month < 12; month++)
        {
            double sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperatures[month, day];
            }
            averageTemperatures[month] = sum / 30.0;
        }

        return averageTemperatures;
    }

    static void printAverageTemperatures(double[] averageTemperatures)
    {
        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine($"Месяц {month + 1}: {averageTemperatures[month]:F2} градусов");
        }
    */
    
        /* Задание 5
        Random random = new Random();
        Dictionary<string, int[]> temperatureDictionary = new Dictionary<string, int[]>();

        string[] months =
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь",
            "Декабрь"
        };

        Console.WriteLine("Температуры по месяцам:");

        foreach (var month in months)
        {
            int[] temperatures = new int[30];
            Console.Write($"{month}: ");

            for (int day = 0; day < 30; day++)
            {
                temperatures[day] = random.Next(-20, 30);
                Console.Write($"{temperatures[day]}\t");
            }

            temperatureDictionary.Add(month, temperatures);
            Console.WriteLine();
        }

        Dictionary<string, double> averageTemperatureDictionary = calculateAverageTemperatures(temperatureDictionary);

        Console.WriteLine("\nСредние температуры по месяцам:");
        foreach (var entry in averageTemperatureDictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value:F2} градусов");
        }

        var sortedAverageTemperatures = new SortedDictionary<double, string>();
        foreach (var entry in averageTemperatureDictionary)
        {
            sortedAverageTemperatures.Add(entry.Value, entry.Key);
        }
        
        Console.WriteLine("\nОтсортированные средние температуры:");
        foreach (var entry in sortedAverageTemperatures)
        {
            Console.WriteLine($"{entry.Value}: {entry.Key:F2} градусов");
        }
    }

    static Dictionary<string, double> calculateAverageTemperatures(Dictionary<string, int[]> temperatureDictionary)
    {
        Dictionary<string, double> averageTemperatureDictionary = new Dictionary<string, double>();

        foreach (var entry in temperatureDictionary)
        {
            double sum = 0;
            foreach (var temperature in entry.Value)
            {
                sum += temperature;
            }

            double averageTemperature = sum / entry.Value.Length;
            averageTemperatureDictionary.Add(entry.Key, averageTemperature);
        }

        return averageTemperatureDictionary;
    */
    }
    
}