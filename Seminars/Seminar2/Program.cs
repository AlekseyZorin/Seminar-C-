// Задача 1
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// void MaxDecimal(int num)
// {
//     int ed = num % 10;    // единицы (если число 78 то вывод 8) 
//     int dec = num / 10;   // десятки (если число 78 то вывод 7)
//     if(ed>dec)
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {ed}");
//     }
//     else
//     {
//         Console.WriteLine($"Большая цифра числа {num} -> {dec}");

//     }

// }

// int num = new Random().Next(10, 100); // от 10 до 99

// MaxDecimal(num);

// Задача 2
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int DeletDecimal(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }

// int randomnumber = new Random().Next(100, 1000);
// Console.WriteLine(randomnumber);
// int result = DeletDecimal(randomnumber);//
// Console.WriteLine(result);//
//Либо
// Console.WriteLine(DeletDecimal(randomnumber));

// Задача 3

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да


// void Devid723(int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//       Console.WriteLine("Данное число делиться на 7 и 23 без остатка");
//     }
//     else
//     {
//         Console.WriteLine("Данное чиcло НЕ делится на 7 и на 23 без остатка");
//     }
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Devid723(num);


// Задача 4

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


// void KratDecimal(double num1, double num2)
// {
//     if(num1 % num2 == 0)
//     {
//         Console.WriteLine("Кратно");
//     }
//     else
//     {
//         Console.WriteLine($"Остаток от деления {num1}/{num2} = {num1 % num2}");
//     }

// }

// Console.WriteLine("Введите первое число: ");
// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// KratDecimal(num1, num2);