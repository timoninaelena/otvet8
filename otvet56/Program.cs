// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Кол-во строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Кол-во строк столбцы: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int m, int n, int minRandom, int maxRandom)
{
int[,] result = new int[m, n];
for (int i = 0; i < result.GetLength(0); i++) 
{
for (int j = 0; j < n; j++) 
{
result[i, j] = new Random().Next(minRandom, maxRandom + 1); //
}
}
return result;
}

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

int MinSum = 100;
int indexLine = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < MinSum)
    {
        MinSum = sum;
        indexLine++;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexLine}. ");
}
int [,] resultMatrix = GetArray(rows, columns,0,10);
PrintArray(resultMatrix);
