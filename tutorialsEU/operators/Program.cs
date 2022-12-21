using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num1 = 5;

        // unary operators
        int num2 = -num1;
        Console.WriteLine(num2);

        bool isSunny = true;
        // logical negation
        Console.WriteLine($"Is it always sunny in Philadelphia?! {!isSunny}");

        // increment/decrement operators
        Console.WriteLine($"num is {num1}");
        Console.WriteLine($"num is {num1++}"); // post-increment
        Console.WriteLine($"num is {++num1}"); // pre-increment
        Console.WriteLine($"num is {--num1}"); // pre-decrement
        Console.WriteLine($"num is {num1--}"); // post-decrement

        // arithmetic operators
        int result = num1 + num2; // addition
        Console.WriteLine($"result is {result}");
        result = num1 - num2; // subtraction
        Console.WriteLine($"result is {result}");
        result = num1 * num2; // multiplication
        Console.WriteLine($"result is {result}");
        result = num1 / num2; // (integer) division
        Console.WriteLine($"result is {result}");
        result = num1 % num2; // modulus operator
        Console.WriteLine($"result is {result}");

        // relational operators
        isSunny = num2 < num1; // strictly less than
        Console.WriteLine(isSunny);
        // others include
        // > : strictly greater than
        // <= less than or equal
        // >= greater than or equal

        // equality operators
        isSunny = num1 == num2; // equal to
        Console.WriteLine(isSunny);
        isSunny = num1 != num2; // not equal to
        Console.WriteLine(isSunny);

        // conditional operators
        isSunny = (num1 != num2) && (num2 > num1); // and
        Console.WriteLine(isSunny);
        isSunny = (num1 != num2) || (num2 > num1); // or
        Console.WriteLine(isSunny);

        // unary operator (enhanced if statement/short-form if-conditional)
        string state;
        // if (num1 < 0)
        // { state = "solid"; }
        // else
        // { state = "liquid"; }
        state = (num1 < 0) ? "ice" : (num1 > 100) ? "steam" : "liquid";
        Console.WriteLine(state);
    }
}
