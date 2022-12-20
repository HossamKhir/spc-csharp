// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// INFO: jagged arrays syntax is similar to multi-dimensional arrays in C++
// INFO: declare jagged array
int[][] jaggedArr = new int[3][];

// NOTE: jagged arrays could have arrays of different sizes
jaggedArr[0] = new int[] { 2, 3, 5, 7, 11 };
jaggedArr[1] = new int[3];
jaggedArr[2] = new int[2];

// NOTE: also jagged arrays could be defined
int[][] jArr = new int[][] {
    new int[] {3, 2},
    new int[] {5, 10, 28},
};

foreach (var arr in jArr)
{
    // Console.WriteLine(arr);
    foreach (var val in arr)
    {
        Console.WriteLine(val);
    }
}