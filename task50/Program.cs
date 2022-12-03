// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
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

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max, int pos1, int pos2)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    if (pos1 > 0 && pos1 < matrix.GetLength(0) && pos2 > 0 && pos2 < matrix.GetLength(1))
    {
        Console.WriteLine($"{pos1},{pos2} -> there is such element");
    }
    else
    {
        Console.WriteLine($"{pos1},{pos2} -> there is no such element");
    }
    return matrix;
}

Console.WriteLine("Enter first position: ");
int position1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second position: ");
int position2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrixRndInt(3, 4, -99, 100, position1, position2);
PrintMatrix(matrix);

