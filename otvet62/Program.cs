// Задача 62: Заполните спирально массив 4 на 4.


int rows = 4;
int colums = 4;

int[,] sqareMatrix = new int[rows, colums];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(sqareMatrix);

void PrintArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] / 10 <= 0)
      Console.Write($" {matrix[i,j]} ");

      else Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}
