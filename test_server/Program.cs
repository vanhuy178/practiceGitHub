// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// GET THE LENGTH OD 2D ARRAY
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}