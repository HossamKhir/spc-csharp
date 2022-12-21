// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public static class Program
{
    private const int DATUM = 10;
    private const int STEP = 1;
    public static void Main(string[] args)
    {
        // INFO: general syntax
        for (int counter = 0; counter < DATUM; counter += STEP)
        {
            Console.WriteLine(counter);
        }
        PrintOddNumber();
    }

    public static void PrintOddNumber()
    {
        for (int index = 1; index < DATUM; index += 2)
        {
            Console.WriteLine(index);
        }
    }
}