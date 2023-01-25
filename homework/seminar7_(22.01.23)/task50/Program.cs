
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix = new int[4,4];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Введите позицию элемена в строке: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемена в  столбце: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки: ");
int numberTest = Convert.ToInt32(Console.ReadLine());

if (matrix[linesVol,columnsVol] == numberTest)
{
    Console.WriteLine ($"Введенное число- {numberTest} в массиве есть ");
}
else
{
    Console.WriteLine ($"Введенное число отсутствует в массиве {numberTest}");
}