// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// Console.WriteLine("Input first number");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input second number");
// double num2 = Convert.ToDouble(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"max = {num1} min = {num2}");
// }
// else
// {
//     Console.WriteLine($"max = {num2} min = {num1}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input second number");
// double num2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input third number");
// double num3 = Convert.ToDouble(Console.ReadLine());
// double max = 0;

// if (num1 > num2)
// {
//     max = num1;
// }
// else
// {
//     max = num2;
// }
// if (num3 > max)
// {
//     max = num3;
// }
// Console.WriteLine($"max = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine($"{num} The number is even");
// }
// else
//  {
//      Console.WriteLine($"{num} The number is odd");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// int numEven = 1;

// while (numEven <= num)
// {
//     if (numEven % 2 == 0)
//     {
//         Console.Write(numEven + " ");
//     }
//     numEven++;
// }