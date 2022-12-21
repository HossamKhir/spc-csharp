using System;

class Program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        // Console.WriteLine("Hello, World!");
        // WriteSomething();
        // WriteSomethingSpecific("An argument");

        // a method w/ return could be saved into variables
        int res = Add(15, 31);
        Console.WriteLine(res);

        // or use the method return directly as an argument for another method
        Console.WriteLine(Add(15, 31));
        Add(Add(1, 2), Add(3, 4));

        Console.WriteLine(Multiply(25, 25));

        Console.Read();
    }

    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double divide(double num1, double num2)
    {
        // NOTE: dividing integers by integers results in integer division
        return num1 / num2;
    }

    // public static void WriteSomething()
    // {
    //     Console.WriteLine("I am called from a method");
    // }

    // public static void WriteSomethingSpecific(string text){
    //     Console.WriteLine(text);
    // }

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
        return num1 + num2;
        // int result = num1 + num2;
        // return result;
    }
}