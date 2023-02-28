//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;  
//     }
//     return array;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// int[] reversedArray = ReverseArray(myArray);
// ShowArray(myArray);



//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool ChekTriangle(int x, int y, int z)
// {
//     if (x < y + z && y < z + x && z < x + y)
//     {
//         return true;
//     }
//     return false;
// }
// Console.Write("Input length of triangle a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input length of triangle b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input length of triangle c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Does such triangle with sides {a} and {b} and {c} exist? {ChekTriangle(a, b, c)}");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b.
//(числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, 
//а последубщие это сумма двух передыдущих
//[0, 1, 2, 3, 5, 8, 13, ... ] )


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] FebDigit(int n, int firstNum, int secNum)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) array[i] = firstNum;
//         else if (i == 1) array[i] = secNum;
//         else array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Дописать вводные для int firstNum, int secNum
// ShowArray(FebDigit(n,8,9));




//Задача 4. ****Напишите программу, которая 
//будет преобразовыватьдесятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10


// string DecNum(int num)
// {
//     string res = string.Empty;
//     while (num != 0)
//     {
//         res = num % 2 + res;
//         num = num / 2;
//     }
//     return res;
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum(num));

