// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Введите количество строк 1-й матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-й матриц");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-й матриц");
int l = Convert.ToInt32(Console.ReadLine());

int[,] firstMatr = new int[m, n];
FillArray(firstMatr);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatr);

int[,] secondMatr = new int[n, l];
FillArray(secondMatr);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatr);

int[,] resultMatr = new int[m,l];

MultiplyMatrix(firstMatr, secondMatr, resultMatr);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatr);

void MultiplyMatrix(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
  for (int i = 0; i < resultMatr.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatr.GetLength(1); k++)
      {
        sum += firstMatr[i,k] * secondMatr[k,j];
      }
      resultMatr[i,j] = sum;
    }
  }
}