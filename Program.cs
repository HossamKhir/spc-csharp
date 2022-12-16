// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace Properties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Box box = new Box();
            // box.Length = 5.0;
            // box.Width = 1.0;
            // box.Height = 1;
            Box box = new Box(5, 1, 1);
            Console.WriteLine(box.Volume);
        }
    }
}