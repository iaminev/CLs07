/*Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


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

double[] GetColumnsArithmeticMeans(int[,] array)
{
    double[] columnsArithmeticMeans = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            columnsArithmeticMeans[i] += array[j, i];
        }
        columnsArithmeticMeans[i] /= array.GetLength(0);
    }
    return columnsArithmeticMeans;
}

int rows = 4;
int cols = 8;
int[,] array = GetArray(rows, cols, maxValue: 9);
PrintArray(array);
double[] columnsArithmeticMeans = GetColumnsArithmeticMeans(array);

Console.Write($"The arithmetic means of columns are: ");
for (int i = 0; i < columnsArithmeticMeans.Length; i++)
{
    Console.Write($"{columnsArithmeticMeans[i]:F1}{(i == (columnsArithmeticMeans.Length - 1) ? "" : "; ")} ");

    //Console.Write($"{columnsMeans[i]:F1} ");
}

