using System;

namespace ConsoleApp2;

internal class Program
{

    // getters and setters vs properties exercise
    public static int Bloop { get; set; }

    public static void Main()
    {
        Bloop = 0;
        Console.WriteLine("Hello, World!");
        int Num = Convert.ToInt32(Console.ReadLine());
        int Before = Bloop;
        int After = Bloop + Num;
        Console.WriteLine($"Before: {Before}");
        Console.WriteLine($"After: {After}");






    }
}