// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int index = 0; index < 10; ++index)
{
    if (index == 3)
    {
        System.Console.WriteLine("No 3 for you!");
        continue; // skips the current iteration, and starts the next iteration
    }
    if (index == 6)
    {
        Console.WriteLine("You shall not pass!");
        break; // exits from (breaks) the loop, and go outside it
    }
    Console.WriteLine(index);
}
Console.WriteLine("That's it, folks!");
