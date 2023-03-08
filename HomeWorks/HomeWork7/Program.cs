// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int columns, int rows, double minValue, double maxValue)
// {
//     double[,] newArray = new double[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = Math.Round(rand.NextDouble(), 3) * (maxValue - minValue) + minValue;
//         }
//     }
//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2DRandomArray(columns, rows, minValue, maxValue);

// Show2DArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void CheckElement(int[,] array, int indexRows, int indexCols)
// {
//     if(indexRows < 0 || indexRows > array.GetLength(0) || indexCols < 0 || indexCols > array.GetLength(1))
//     {
//         Console.WriteLine("Number not array");
//     }
//     else Console.WriteLine($"Number = {array[indexRows, indexCols]}");
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter indexRows of elements: ");
// int indexRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter indexCols of elements: ");
// int indexCols = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);

// Show2DArray(array);
// CheckElement(array, indexRows, indexCols);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void AverageColumns(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i, j];
//         }
//         double average = Math.Round(sum / array.GetLength(0), 2);
//         Console.WriteLine($"Sum column {j+1} = {sum}, average = {average}");
//     }
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);

// Show2DArray(array);
// AverageColumns(array);