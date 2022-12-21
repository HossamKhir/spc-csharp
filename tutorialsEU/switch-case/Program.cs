// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int age = 16;
        // switch-case can be used like C/C++ switch, with integers, characters & enums
        switch (age)
        {
            case < 16: // switch with comparison operator?
                Console.WriteLine("Too young to drive!");
                break;
            case <= 65:
                Console.WriteLine("Still got it!");
                break;
            case > 65:
                Console.WriteLine("Too old, senior!");
                break;
            default:    // NOTE: unreachable code, bad practice
                Console.WriteLine("default");
                break;
        }

        // switch could also be used w/ strings like C++
        string username = "Ivan";
        switch (username.ToLower())
        {
            case "ivan":
                Console.WriteLine("До свидания");
                break;
            case "harry":
                Console.WriteLine("Cheerio!");
                break;
            case "louis":
                Console.WriteLine("Au revoir!");
                break;
            case "raul":
                Console.WriteLine("Adiós!");
                break;
            case "omar":
                Console.WriteLine("إلى اللقاء!");
                break;
        }

    }
}