// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[] tripleArray = CreateRandomArray(4, 1, 100);
int ruslt = 0;
for (int i = 0; i < tripleArray.Length; i++)
{
    if (i % 2 != 0)
    {
        ruslt += tripleArray[i];
    }
}
ShowArray(tripleArray);
Console.WriteLine(ruslt);