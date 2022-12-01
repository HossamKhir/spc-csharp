using System;

namespace spc_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string name = "ObiWan";
      // concatenation
      Console.WriteLine("Hello, " + name);
      // we can have arithmatic operations
      Console.WriteLine(2 + 2 * 6);

      // there are several types of variables, we seen string above ^
      int number = 2;
      float price = 3.99f;

      Console.WriteLine(number * price);
    }
  }
}
