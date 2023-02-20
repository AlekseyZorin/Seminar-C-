// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введи пятизначное число");
// int n = Convert.ToInt32(Console.ReadLine());

// if(n < 10000 || n > 100000) 
// {
//     Console.WriteLine("Вы ввели недопустимое число");
// }
// else Palindrom(n);

// void Palindrom(int n)
// {
//     int firstNamber = n / 10000;
//     int secondNamber = (n / 1000) % 10;
//     int fourthNamber = (n / 10) % 10;
//     int fifthNamber = n % 10;
//     if(firstNamber == fifthNamber && secondNamber == fourthNamber) 
//     {
//         Console.WriteLine("Данное число является палиндромом");
//     }
//     else Console.WriteLine("Данное число НЕ является палиндромом");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 3);
//     // return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));
// }

// Console.WriteLine("Input coordinate X for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z for first point: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X for second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y for second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Z for second point: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa, ya, za, xb, yb, zb)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число, чтобы увидеть квадраты чисел до этого числа");
// int n = Convert.ToInt32(Console.ReadLine());
// int y = 1;

// void Quad(int n)
// {
//     while (y <= n)
//     {
//         Console.WriteLine($"Куб числа {y} равен {Math.Pow(y, 3)}");
//         y++;
//     }
// }

// Quad(n);