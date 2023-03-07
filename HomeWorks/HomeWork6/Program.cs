// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input number array index {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int OverZero(int[] array)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) counter++;
//     }
//     return counter;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// Console.WriteLine($"Number over zero in array -> {OverZero(myArray)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Input value b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input value k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input value b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input value k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double[] myArray = Intersection(b1, k1, b2, k2);

// if (k1 == k2 && b1 == b2) Console.WriteLine("These lines coincide");
// else if (k1 == k2) Console.WriteLine("These lines are parallel");
// else Console.WriteLine($"Координаты точки пересечения: (x= {myArray[0]}, y= {myArray[1]})");

// double[] Intersection(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     double[] result = { x, y };
//     return result;
// }
