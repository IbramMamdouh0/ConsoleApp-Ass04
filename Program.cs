using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Ass04
{ }
class Program
{
    static void Main()
    { 
        SumArray.Run();
    }
}
//01
class SumArray
{
    public static void Run()
    {
        Console.Write("Enter array elements: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Sum = " + arr.Sum());
    }
}
//02
class MergeArrays
{
    public static void Run()
    {
        Console.Write("Enter first array: ");
        int[] a1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.Write("Enter second array: ");
        int[] a2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] merged = a1.Concat(a2).ToArray();
        Array.Sort(merged);

        Console.WriteLine("Merged and sorted: " + string.Join(" ", merged));
    }
}
//03
class CountFrequency
{
    public static void Run()
    {
        Console.Write("Enter array: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (var item in arr.Distinct())
        {
            int count = arr.Count(x => x == item);
            Console.WriteLine($"{item} appears {count} times");
        }
    }
}
//04
class SecondLargest
{
    public static void Run()
    {
        Console.Write("Enter array: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();

        if (arr.Length < 2)
        {
            Console.WriteLine("❌ Not enough unique elements.");
            return;
        }

        Array.Sort(arr);
        Console.WriteLine("Second largest = " + arr[arr.Length - 2]);
    }
}
//05
class LongestDistance
{
    public static void Run()
    {
        Console.Write("Enter array: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> firstIndex = new Dictionary<int, int>();
        int maxDistance = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!firstIndex.ContainsKey(arr[i]))
                firstIndex[arr[i]] = i;
            else
                maxDistance = Math.Max(maxDistance, i - firstIndex[arr[i]] - 1);
        }

        Console.WriteLine("Longest distance = " + maxDistance);
    }
}
//06
class ReverseWords
{
    public static void Run()
    {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        Console.WriteLine("Reversed: " + string.Join(" ", words));
    }
}
//07
class Copy2DArray
{
    public static void Run()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array1 = new int[rows, cols];
        int[,] array2 = new int[rows, cols];

        Console.WriteLine("Enter values row by row:");

        for (int i = 0; i < rows; i++)
        {
            int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                array1[i, j] = row[j];
                array2[i, j] = array1[i, j];
            }
        }

        Console.WriteLine("Copied array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(array2[i, j] + " ");
            Console.WriteLine();
        }
    }
}
//08
class ReverseArray
{
    public static void Run()
    {
        Console.Write("Enter array: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Reverse(arr);
        Console.WriteLine("Reversed: " + string.Join(" ", arr));
    }
}

