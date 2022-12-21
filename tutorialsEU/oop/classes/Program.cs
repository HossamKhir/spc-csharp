// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
// in order to be able to use a class defined outside the current namespace, the
//  namespace of the class in question should be loaded by the `using` directive
using Classes;
public class Program
{
    public static void Main(string[] args)
    {
        // INFO: instantiation using the new keyword
        Human bond = new Human();
        // INFO: public members are accessed by the dot `.` operator
        bond.Forename = "James";
        bond.Surname = "Bond";
        bond.IntroduceYourself();
    }
}
