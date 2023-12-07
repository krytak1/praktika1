using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        /* Задание 1
        int n = Int32.Parse(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающим число n: {product}");
        */
        /* Задание 2
        try
        {
            string[] lines = File.ReadAllLines("numsTask2.txt");
            
            float[] nums = lines[0].Split(';').Select(float.Parse).ToArray();
            float sum = 0;

            foreach (var num in  nums)
            {
                if (num == 0)
                {
                    break;
                }

                if (num > 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Сумма положительных чисел до первого нуля: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* Задание 3
        try
        {
            string[] lines = File.ReadAllLines("numsTask3.txt");
            
            int[] nums = lines[0].Split(',').Select(int.Parse).ToArray();
            int indexOfZero = Array.IndexOf(nums, 0);
            if (indexOfZero == -1)
            {
                Console.WriteLine("Нуля нет в последовательности");
                return;
            }

            int[] sequence = nums.Take(indexOfZero).ToArray();
            double ratio = Convert.ToDouble(sequence.Min()) / sequence.Max();

            Console.WriteLine($"Отношение минимального к максимальному: {ratio}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* Задание 4
        try
        {
            string[] lines = File.ReadAllLines("numsTask4.txt");
            
            int[] nums = lines[0].Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    count++;
                }
            }
           
            Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* Задание 5
        Console.WriteLine("Введите a: ");
        double a = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите b: ");
        double b = Int32.Parse(Console.ReadLine());

        double xMin = -1.0;
        double xMax = 3.0;
        double yMin = -2.0;
        double yMax = 4.0;


        if ((a >= xMin && a <= xMax) && (b >= yMin && b <= yMax))
        {
            Console.WriteLine($"Точка ({a};{b}) принадлежит области.");
        }
        else
        {
            Console.WriteLine($"Точка ({a};{b}) не принадлежит области.");
        }
        */
        /* Задание 6
        Console.WriteLine("Введите a: ");
        double a = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите b: ");
        double b = Int32.Parse(Console.ReadLine());

        double x1 = 0;
        double y1 = 2;
        
        double x2 = -2;
        double y2 = -3;
        
        double x3 = 2;
        double y3 = -3;


        double areaOfTriangle = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        double areaOfSubTriangle1 = 0.5 * Math.Abs(a * (y2 - y3) + x2 * (y3 - b) + x3 * (b - y2));
        double areaOfTSubTriangle2 = 0.5 * Math.Abs(x1 * (b - y3) + a * (y3 - y1) + x3 * (y1 - b));
        double areaOfTSubTriangle3 = 0.5 * Math.Abs(x1 * (y2 - b) + x2 * (b - y1) + a * (y1 - y2));
        if (Math.Abs(areaOfTriangle - (areaOfSubTriangle1 + areaOfTSubTriangle2 + areaOfTSubTriangle3)) < 0.0001)
        {
            Console.WriteLine($"Точка ({a};{b}) принадлежит области.");
        }
        else
        {
            Console.WriteLine($"Точка ({a};{b}) не принадлежит области.");
        }
        */
    }
}