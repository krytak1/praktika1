using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        /* Задание 1
        try
        {
            string[] lines = File.ReadAllLines("input.txt");

            int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();

            int numberOfTickets = int.Parse(lines[1]);

            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                for (int i = 2; i < 2 + numberOfTickets; i++)
                {
                    int[] ticketNumbers = lines[i].Split(' ').Select(int.Parse).ToArray();

                    int matches = ticketNumbers.Intersect(chosenNumbers).Count();
                    
                    writer.WriteLine(matches >= 3 ? "Lucky" : "Unlucky");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
        /* ЗАДАНИЕ 2
        try
        {
            string[] lines = File.ReadAllLines("nums.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] numbers = lines[i].Split(' ');

                lines[i] = string.Join(" ", numbers.Where(number => isEven(number)));
            }
            File.WriteAllLines("nums.txt", lines);

            Console.WriteLine("Четные числа удалены успешно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
    }

    static bool isEven(string number)
    {
        if (int.TryParse(number, out int num))
        {
            return num % 2 != 0;
        }

        return true;
    }
    */
        /* Задание 3
        try
        {
            string[] lines = File.ReadAllLines("numbers.txt");

            int[] height = lines[0].Split(' ').Select(int.Parse).ToArray();

            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            
            while (left < right)
            {
                int h = Math.Min(height[left], height[right]);
                int w = right - left;
                maxArea = Math.Max(maxArea, h * w);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine($"Максимальная площадь воды: {maxArea}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            throw;
        }
        */
    }
}