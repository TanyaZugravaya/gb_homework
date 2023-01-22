// Решение задач на онлайн семинарах.
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] CreateRandomArray(int N, int start, int end){
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Revers(int [] array){

//     int temp = 0;

//     for (int i=0; i < array.Length/2; i++){
//         temp = array[i];
//         array[i] = array[(array.Length - 1) - i];
//         array[(array.Length - 1) - i] = temp;
//     }

//     return array;
// }


// int [] array = CreateRandomArray(7, -5, 5);
// Console.Write("Массив:                  ");
// ShowArray(array);

// Revers(array);
// Console.Write("Отсортированный массив:  ");
// ShowArray(array);


// //  задача2 сем
// int[] CreateRandomArray(int N, int start, int end){

//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int[] CreateArray(){
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void checkTriangle(int [] array){

//     if( array[0] < array[1]+array[2] && 
//         array[1] < array[0]+array[2] &&
//         array[2] < array[0]+array[1])
//         Console.WriteLine("Такой триугольник существует");
//     else
//         Console.WriteLine("Такой триугольник не существует");

// }

// int [] array = CreateArray();
// checkTriangle(array);


// // зад 2
// Console.Write("Введите число: ");  // первый вариант
// int number = Convert.ToInt32(Console.ReadLine());

// string accumulator = "";

// while (number > 0)
// {
//     accumulator += number % 2;
//     number /= 2;
// }


// Console.Write(accumulator);

// // второй вариант

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Revers(int[] array)
// {

//     int temp = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[(array.Length - 1) - i];
//         array[(array.Length - 1) - i] = temp;
//     }

//     return array;
// }

// int[] intToBin(int num)
// {

//     int temp = num;
//     int count = 0;

//     while (Convert.ToBoolean(temp))
//     {
//         temp /= 2;
//         count++;
//     }


//     int[] array = new int[count];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = num % 2;
//         num /= 2;
//     }

//     Revers(array);

//     return array;
// }

// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num);
// int[] array = intToBin(num);

// ShowArray(array);

// // зад 3


// Console.WriteLine($"Введите количество чисел Фибоначчи");
// int val_1 = Convert.ToInt32(Console.ReadLine());

// int param_1 = 0;
// int param_2 = 1;
// int temp = param_2;

// temp = param_1 + param_2; //1
// Console.WriteLine(param_1); //0
// Console.WriteLine(param_2); // 1

// for (int i = 0; i < val_1; i++)
// {
//     temp = temp + param_2; // 2
//     param_1 = param_2;
//     param_2 = temp - param_1;

//     Console.WriteLine(temp);

// }


// // задание 4

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     { result[i] = inArray[i]; }
//     return result;
// }

// // Семинар 7 задание 1 лекция 6 задние рещено в ней, нужно дописать функции


// // int [,] matrix = new int[3,4];
// // PrintArray 


// ЗАДАНИЯ ГРУППЫ

// Матрица случайных чисел
// Console.Clear();

// int [,] matrix = new int[4,4];
// FillArray(matrix);
// Console.WriteLine("Задача 48.");
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine("Задача 49.");
// FillArraySqr(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// Console.WriteLine("Задача 51.");
// FillArrayDiag(matrix);

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = i + j;
//         }
//     }
// }

// void FillArraySqr(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) matr[i,j] = matr[i,j] * matr[i,j];
//         }
//     }
// }

// void FillArrayDiag(int[,] matr)
// {
//     int count = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j) count += matr[i,j];
//         }
//     }

//     Console.WriteLine($"Сумма чисел диагонали: {count}");
// }


// семинар 7, задание 48


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5




int [,] matr = new int [3,4];
 for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i + j;
        }
    }
Console.WriteLine(matr);

// // Матрица случайных чисел дз задание 52

// Console.Clear();

// int [,] matrix = new int[4,4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// FillArrayMidl(matrix);


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = i + j;
//         }
//     }
// }

// void FillArrayMidl(int[,] matr)
// {
//     Console.Write("Среднее: ");
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             sum += matr[i,j];
//         }
//         Console.Write($"{sum/matr.GetLength(0)}, ");
//     }
// }