//Задача 1. Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n - 1);
//     }

//     // if (n >= 1) 
//     // {
//     //     ShowNumbers(n - 1); // обраиный порядок 
//     //     Console.Write(n + " ");
//     // }
// }

// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);



//Задание 2. Напишите программу, которая будет принимать на
// вход число и возвращать сумму его цифр.
// 453 -> 12
// int FindSum(int num)
// {
//     if (num > 0)
//         return FindSum(num / 10) + num % 10;
//     else return num;
// }

// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(n));



//Задача 3. Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FindDeap(int m, int n)
// {
//     if (m != n)
//     {
//         if (m < n)
//         {
//             FindDeap(m, n - 1);
//             Console.WriteLine(n + " ");
//         }
//         else
//         {
//             FindDeap(m - 1, n);
//             Console.WriteLine(m + " ");
//         }
//     }
//     else Console.WriteLine(m);
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// FindDeap(m,n);



//Задача 4.Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

// int FindPow(int a, int b)
// {
//     if (b >= 1) return FindPow(a, b - 1) * a;
//     else return 1;
// }

// Console.Write("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindPow(a, b));

