// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i],2)}");
        if (i < arr.Length - 1) Console.Write(", ");


    }
    Console.WriteLine("]");
}
void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4} |");
            else Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

double[] GetArifmeticMean(int[,] matr)
{
    double arifmeticMean = default;
    double[] arr = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        
        }
        arifmeticMean = sum / matr.GetLength(1);
        arr[j] = arifmeticMean;
    }
    return arr;
}

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();

double[] array = GetArifmeticMean(matrix);
PrintArray(array);
