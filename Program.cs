using System;

class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }

    /**
    a method should have an access specifier, a return type, and an identifer,
    and optional parameter list, and a method body in braces

    the access specifier: public
    the return type: int
    the identifier: Add
    the parameter list: int num1, int num2
    */
    public static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }
}