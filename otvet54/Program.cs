// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Write("Кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во строк столбцы: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// 4 параметра:
/// m - кол=во строк, n - кол-во столбцов
/// minRandom, maxRandom
int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
int[,] result = new int[m, n];
for (int i = 0; i < result.GetLength(0); i++) // GetLength(0) - по строчкам(GetLength(0) = m)
{
for (int j = 0; j < n; j++) // GetLength(1) = n
{
result[i, j] = new Random().Next(minRandom, maxRandom + 1); //
}
}
return result;
}
// matrix - табличка m на n - двумерный массив
void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int k = 0; k < matrix.GetLength(1); k++)
{
Console.Write(matrix[i, k] + "\t" );
}
Console.WriteLine();
}
}

void OrderArrayLines(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] > matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}


int [,] resultMatrix = GetArray(rows, columns,0,10);
PrintArray(resultMatrix);
System.Console.WriteLine("В итоге получается вот такой массив:");
OrderArrayLines(resultMatrix);
PrintArray(resultMatrix);