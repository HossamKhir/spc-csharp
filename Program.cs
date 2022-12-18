// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};

// NOTE: foreach loop loops over each individual element, no matter the dimensions
foreach (int num in matrix)
{
    Console.Write(num + " ");
}
Console.WriteLine();

// NOTE: the `Length` property returns the flattened length, instead, the 
//  `GetLength` method accepts an argument for the dimension
// INFO: outer loop, over rows
for (int row = 0; row < matrix.GetLength(0); ++row)
{
    // INFO: inner loop, over columns
    for (int col = 0; col < matrix.GetLength(1); ++col)
    {
        matrix[row, col] *= -1;
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}