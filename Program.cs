// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// INFO: declaring a 2D array of strings
string[,] matrix;

// INFO: declaring a 3D array of integers
int[,,] tensor;

// INFO: defining a 2D array of integer
// NOTE: assigning new values to arrays doesn't work w/o the `new` keyword, only
//  on initialisation (definition)
int[,] array2D = {
    { 1, 2, 3,},
    { 4, 5, 6,},
    { 7, 8, 9,},
};

Console.WriteLine(array2D[1, 1]);

matrix = new string[3, 2]{
    {"one", "two"},
    {"three", "four"},
    {"five", "six"},
};
matrix[1, 1] = "chicken";

// NOTE: `Rank` property tells how many dimension an array has (its rank)
Console.WriteLine(array2D.Rank);
