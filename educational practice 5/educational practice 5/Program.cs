using System;
using System.IO;
using System.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        /* Задание 1
        try
        {
            int[] nums = File.ReadAllText("numsTask1.txt").Split(' ').Select(int.Parse).ToArray();
            
            int minIndex = Array.IndexOf(nums, nums.Min());

            int product = 1;
            for (int i = minIndex + 1; i < nums.Length; i++)
            {
                product *= nums[i];
            }
            Console.WriteLine($"Произведение элементов после минимального: {product}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* Задание 2
        string[] lines = File.ReadAllText("numsTask2.txt").Split(';');
        double[] nums = Array.ConvertAll(lines, double.Parse);
        
        Array.Sort(nums);
        
        File.WriteAllText("numsTask2.txt", string.Join(";", nums.Select(num => num.ToString())));
        
        Console.WriteLine("Числа успешно отсортированы");
        */
        /* Задание 3
        try
        {
            int[] nums = File.ReadAllText("numsTask3.txt").Split(' ').Select(int.Parse).ToArray();
            
            int minIndex = Array.IndexOf(nums, nums.Min());

            int sum = 0;
            for (int i = 0; i < minIndex; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine($"Среднее арифметическое элементов расположенных до минимального: {sum / minIndex}");
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
            int[] nums = File.ReadAllText("numsTask4.txt").Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Max() - nums[i] == 1)
                {
                    sum += nums[i];
                }
            }
            Console.WriteLine($"Сумма элементов, отличающихся от максимального от 1: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* Задание 5
        try
        {
            int[] nums = File.ReadAllText("numsTask5.txt").Split(' ').Select(int.Parse).ToArray();
            
            int minIndex = Array.IndexOf(nums, nums.Min());
            int maxIndex = Array.IndexOf(nums, nums.Max());

            int sum = 0;
            int count = 0;
            if (minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    sum += nums[i];
                    count++;
                }
            }
            else
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    sum += nums[i];
                    count++;
                }
            }
            
            Console.WriteLine($"Среднее арифметическое элементов расположенных между минимальным и максимальным: {sum / count}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
    }
}