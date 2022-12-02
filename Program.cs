using System;

class Program
{
  /// <summary>
  /// This is the entry point of the programme
  /// </summary>
  static void Main(string[] args)
  {
    // in C#, naming conventions follow camelCase
    float productA = 3.99f; // `f` is for float
    float productB = 11.99f;
    float productC = 5.75f;

    float total = productA + productB + productC;

    float vat = 19f;

    float totalTax = total * vat / 100;

    // C# also accepts shorthand assignment operators 
    total += totalTax;

    Console.WriteLine("Total price is " + total);

    /* This is a multiline comment
      // a declaration is a statement that tells the variable type
      int declaration;
      // the definition is a statement that declares the variable type, and set a value on it
      int definition = 1;

      // NOTE: both definition & declaration are done once
      // no variable would be redeclared or redefined

      declaration = definition + definition;

      Console.WriteLine("Result is " + declaration);

      Console.WriteLine("Hello world");
      */
  }
}