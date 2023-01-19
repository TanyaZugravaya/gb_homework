// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int a = 1;

for (int i = 0; i < degree; i++)
{
    a = a * num;
}

Console.WriteLine($"Введеное число {num} в степени {degree} равно {a}");