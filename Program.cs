// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Program
{
    const int DATUM = 25;
    public static void Main(string[] args)
    {
        // int temperature = 25;
        try
        {
            // int temperature = int.Parse(Console.ReadLine());
            int temperature;
            bool isParsed = int.TryParse(Console.ReadLine(), out temperature);
            if (temperature < DATUM)
            {
                Console.WriteLine("Less than 25C");
            }
            // if (temperature == DATUM)
            else if (temperature == DATUM)
            {
                Console.WriteLine("Yay!!");
            }
            // if (temperature > DATUM)
            else
            {
                Console.WriteLine("Greater than 25C");
            }

        }
        catch (FormatException)
        {
            // TODO: some handling for FormatException
        }
        catch (Exception)
        {
            throw;
        }
    }
}