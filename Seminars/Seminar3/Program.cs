//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuar(double x, double y) // FindQuar(четверть)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }
// Console.WriteLine("Input x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"The point with coordinates({x}, {y}) is in {FindQuar(x, y)} quarter"); //($"Точка с координатами({x}, {y}) находиться в {FindQuar(x, y)} четверти")


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double FindDistance(double xa, double ya, double xb, double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2)),3) ;  // Math.Sqrt - этот класс(Math) возвращает квадратный корень числа(в данном случае выражения)
//     // return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));              // Math.Pow возводит число в заданную степень, в данном случае мы вычисляем это число отнимая из одной переменной другую и далее возводим её в квадрат
// }                                                                         // Math.Round округляет полученное число до указанного количества знаков после зяпятой В нашем случаи до 3
//                                                                               // ставится в конче  после запятой 

// Console.WriteLine("Input coordinate X for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X for second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate Y for second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa, ya, xb, yb)}");


//Задача 3.Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Please enter a quarter number (1-4): " );
// int qart = Convert.ToInt32(Console.ReadLine());

// void FindDiapozone(int qart)
// {
//     if (qart == 1) Console.WriteLine("x > 0; y > 0");
//     if (qart == 2) Console.WriteLine("x < 0; y > 0");
//     if (qart == 3) Console.WriteLine("x < 0; y < 0");
//     if (qart == 4) Console.WriteLine("x > 0; y < 0");
//     if (qart >= 5) Console.WriteLine("Invalid quarter number");
// }

// FindDiapozone(qart);


//Задача 4. Напишите программу которая принимает на вход число (N)
// и выдает на консоль квадраты чисел от 1 до N


// Console.WriteLine("Введите число, чтобы увидеть квадраты чисел до этого числа");
// int n = Convert.ToInt32(Console.ReadLine());
// int y = 1;

// void Quad(int n)
// {
//     while (y <= n)
//     {
//         Console.WriteLine($"Корень числа {y} равен {Math.Pow(y, 2)}");
//         y++;
//     }
// }

// Quad(n);