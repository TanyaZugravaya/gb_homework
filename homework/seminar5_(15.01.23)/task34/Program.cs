// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// 345, 897, 568, 234] -> 2

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


int[] tripleArray = CreateRandomArray(4, 100, 1000);
int count = 0;

for (int i = 0; i < tripleArray.Length; i++)
{
    if (tripleArray[i] % 2 == 0)
    {
        count += 1;
    }
}
ShowArray(tripleArray);
Console.WriteLine(count);