// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Write("Введите число: ");
    string value = Console.ReadLine();
    int sum = 0;
    for (int i = 0; i < value.Length; i++)
    {
      int number = int.Parse(Convert.ToString(value[i]));
      sum += number;
    }
    Console.Write($"Сумма цифр заданного числа равна {sum} ");



