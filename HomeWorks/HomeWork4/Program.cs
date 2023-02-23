// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// 1 Способ
// double Degree(int a, int b)
// {
//   return Math.Pow(a, b);
// }
// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write(Degree(a, b));

// 2 Способ
// int Degree(int a, int b)
// {
//     int deg = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         deg *= a;
//     }
//     return deg;
// }
// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{a} in degree {b} = {Degree(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumbers(int number)
// {
//     int sum = 0;
//     int ed = 0;
//     while (number > 0)
//     {
//         ed = number % 10;
//         number = number / 10;
//         sum = sum + ed;
//     }
//     return sum;
// }
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Sum of numbers in number {number} = {SumNumbers(number)}");


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(0 , 2);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         Console.Write(array[i]+ " ");
//     }   
// }
// ShowArray(CreateRandomArray());