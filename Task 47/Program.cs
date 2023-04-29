/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] GetArrayDouble(int rows, int cols, double minValue = -9, double maxValue = 9)
{
    double[,] array = new double[rows, cols];
    FillArrayDouble(array, minValue, maxValue);
    return array;
}

void FillArrayDouble(double[,] array, double minValue = -9, double maxValue = 9)
{
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{(array[i, j] > 0 ? " " : "")} {array[i, j]:F1} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = 7;
int cols = 7;
double[,] array = GetArrayDouble(rows, cols, maxValue: 9);
FillArrayDouble(array);
PrintArrayDouble(array);