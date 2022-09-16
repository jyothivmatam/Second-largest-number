using System;
using System.Collections;

   public class Program
{
    public static void Main()

    {
    int[] array = { 50, 20, 18, 16, 17, 46, 58, 23 };
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine("Second Highest Value in Array " + array[1]);
       foreach (var result in array)
        {
            Console.Write(result + " ");
        }
    }
}
