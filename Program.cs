using System;

namespace spc_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      // a declaration is a statement that tells the variable type
      int declaration;
      // the definition is a statement that declares the variable type, and set a value on it
      int definition = 1;

      // NOTE: both definition & declaration are done once
      // no variable would be redeclared or redefined

      declaration = definition + definition;

      Console.WriteLine("Result is " + declaration);

    //   Console.WriteLine("Hello world");
    }
  }
}
