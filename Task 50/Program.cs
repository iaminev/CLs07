/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет*/


int[,] GetArray(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];
    FillArray(array, minValue, maxValue);
    return array;

}

void FillArray(int[,] array, int minValue = 0, int maxValue = 10)
{
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((array[i, j] < 10 ? "  " : " ") + array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadANumber(string message)
{
    System.Console.Write(message);
    return Int32.Parse(Console.ReadLine()!);
}

bool RowAndColumnInRange(int[,] array, int row, int col)
{
    return row <= array.GetLength(0) && col <= array.GetLength(1);
}

int rows = 7;
int cols = 9;
int[,] array = new int[rows, cols];
FillArray(array, maxValue: 9);
PrintArray(array);

int row = ReadANumber("Enter the row number: ");
int col = ReadANumber("Enter the column number: ");

if (RowAndColumnInRange(array, row, col))
{
    System.Console.WriteLine($"The value in [{row}, {col}] is {array[row - 1, col - 1]}");
}
else
{
    System.Console.WriteLine($"There is no value in [{row}, {col}] (out of range)");
}