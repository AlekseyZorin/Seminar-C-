//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
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

// void FindPosNegSum(int[] array)
// {
//     int sumPositiv = 0;
//     int sumNegativ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPositiv += array[i];
//         else sumNegativ += array[i];
//     }
//     Console.WriteLine($"Sum of positive numbers in array -> {sumPositiv}, sum of negative numbers in array -> {sumNegativ}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);

// ShowArray(myArray);
// FindPosNegSum(myArray);




//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
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

// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }



// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = InvertArray(myArray);
// ShowArray(myArray);




//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     int k = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// void FindNumber(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             k = 1;
//             break;
//         }
//     }
//     if (k==1) Console.WriteLine($"Number {number} found at index {i}");
//     else Console.WriteLine($"Number {number} not array");
// }


// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// findNumber(myArray, number);

// из чата 
// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
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
// void findNumber (int[] array, int number)
// {
//     int k = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//                 k = 1;
//                 break;
//         }
//     }
//     if (k == 1)
//     {
//         Console.WriteLine($"число {number} есть массиве");
//     } else{
//         Console.WriteLine($"числа {number} нет в массиве");
//     }
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// findNumber(myArray, number);






//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];    // выделение памяти под массив
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
// int FindDiapazon (int[] array, int minNumber, int maxNumber)
// {
//     int k = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= minNumber && array[i] <= maxNumber )
//         {
//                 k ++;
//         }
//     }
//     return k;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine("Input min number of diapazon: ");
// int minNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max number of diapazon: ");
// int maxNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindDiapazon(myArray, minNumber, maxNumber));