//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] MatrixArray (int[,] array1, int[,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            matrix[i, j] = array1[i,j] * array2[i, j];
        }
    }
    return matrix;
}

Console.Write("Введите количество строк матриц: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матриц: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = GetArray(rows, columns, 0, 10);
int[,] matrix2 = GetArray(rows, columns, 0, 10);
PrintArray(matrix1);

Console.WriteLine();
PrintArray(matrix2);

Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(MatrixArray(matrix1, matrix2));