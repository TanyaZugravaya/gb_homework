// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение точки b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение точки k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение точки b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение точки k2: ");
int k2 = int.Parse(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
Console.WriteLine($"Х равен {x}");

double y =  k1 * x + b1;
Console.WriteLine($"Y равен {y}");
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");