// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите некоторое количество чисел от -1000 до 1000 через пробел: ");

int[] userarray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
for (int i = 0; i < userarray.Length; i++)
{
    if (userarray[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во чисел > 0: {count}");

 