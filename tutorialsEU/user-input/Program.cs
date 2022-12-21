using System;

class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        // Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter a number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"result is\t:\t{num1 + num2}");
        // string input = Console.ReadLine();
        // Console.WriteLine(input);
    }
}