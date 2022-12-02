using System;

class Program
{
    // static float vat = 19f; // this is a static class variable (attribute)

    /// <summary>
    /// This is the entry point of the programme
    /// </summary>
    static void Main(string[] args) // this is called a method
    { // the scope of the Main method starts after this open brace, ends w/ a closing one
      // in C#, naming conventions follow camelCase
        float productA = 3.99f; // `f` is for float
        float productB = 11.99f;
        float productC = 5.75f;

        float total = productA + productB + productC;

        // if the class variable is uncommented, this will overshadow its value,
        // then vat will be 15 instead of 19
        float vat = 15f;

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

    static void calculateVat()
    {
        // System.Console.WriteLine("Vat is " + vat);
        /**
        uncommenting the above line, while the class variable is commented out
        will cause a compilation error, as `vat` is not in the method's scope,
        or the class scope
        */
    }
}