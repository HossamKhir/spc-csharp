// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // bool isAdmin = false;
        bool isRegistered = true;

        string username = Console.ReadLine();
        bool isAdmin = username.ToLower().Equals("admin");
        if (isRegistered)
        {
            Console.WriteLine("Hello there, registered user!");
            if (username != "")
            {
                Console.WriteLine($"Hello there, {username}!");
                if (username.ToLower().Equals("admin"))
                {
                    System.Console.WriteLine($"Hello admin, {username}!");
                }
            }
        }


    }
}