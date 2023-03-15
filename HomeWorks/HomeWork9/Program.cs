// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n - 1); 
//     }
// }
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumMN(int m, int n)
// {

//     if (m < n)
//     {
//         int res = m;
//         if (m == n) return 0;
//         else
//         {
//             m++;
//             res = m + SumMN(m, n);
//             return res;
//         }
//     }
//     else
//     {
//         int res = n;
//         if (n == m) return 0;
//         else
//         {
//             n++;
//             res = n + SumMN(m, n);
//             return res;
//         }
//     }
// }

// void ShowSumMN(int m, int n)
// {
//     if (m < n) Console.Write($"Sum from {m} to {n} = {SumMN(m - 1, n)}");
//     else Console.Write($"Sum from {n} to {m} = {SumMN(m, n - 1)}");
// }

// ShowSumMN(m, n);



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n+1;
//     else if (n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman (m-1, Akkerman(m, n-1));
// }

// Console.WriteLine(Akkerman(2, 3));

