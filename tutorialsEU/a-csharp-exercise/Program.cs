using System;

class Swap
{
    public static void Main(string[] args)
    {
        // swapping two numbers
        int a = 5, b = 20;

        // logic
        int temp = a;
        a = b;
        b = temp;

        // result
        System.Console.WriteLine("a is:\t" + a + "\nb is:\t" + b);
    }
}