using System;

public class Program
{
    public static void Main(string[] args)
    {
        // // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Enter a number!");
        try
        {
            // NOTE: code that might cause exception here
            int input = int.Parse(Console.ReadLine());
            input /= input;
        }
        catch (FormatException) // there can be multiple catch clauses, each for a specific case
        {
            Console.WriteLine("Format exception");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow exception");
        }
        catch (DivideByZeroException)
        {
            System.Console.WriteLine("Divide by 0 exception");
        }
        catch (Exception) // also there can be a generic catch for any form of non-specified exceptions
        {
            Console.WriteLine("Generic exception");
        }
        finally // there is also an optional finally block, that executes no matter the outcome
        {
            Console.WriteLine("Finally!!!");
        }
    }
}