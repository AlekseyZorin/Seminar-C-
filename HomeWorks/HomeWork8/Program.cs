// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] FromMaxToMin(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, k] > array[i, j]) 
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);

// Show2DArray(FromMaxToMin(myArray));



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     if (rows == columns) // проверяет массив на прямоугольность
//     {
//         Console.WriteLine("Rows and columns do not have to match");
//         return newArray;
//     }

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

// void MinimumLineSum(int[,] array)
// {
//     int sumMin = int.MaxValue;
//     int indexMin = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array[i, j];
//         }
//         if (sumRow < sumMin)
//         {
//             sumMin = sumRow;
//             indexMin = i+1;  // +1 для удобства пользователя 
//         }
//     }
//     Console.WriteLine($"Row number with the smallest sum of elements {sumMin} -> {indexMin} row");
// }


// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Show2DArray(myArray);
// MinimumLineSum(myArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Matrix1(int rowsMatrix1, int columnsMatrix1, int minValueMatrix1, int maxValueMatrix1) // маирица 1
// {
//     int[,] newArray1 = new int[rowsMatrix1, columnsMatrix1];

//     for (int i = 0; i < rowsMatrix1; i++)
//     {
//         for (int j = 0; j < columnsMatrix1; j++)
//         {
//             newArray1[i, j] = new Random().Next(minValueMatrix1, maxValueMatrix1 + 1);
//         }
//     }
//     return newArray1;
// }

// int[,] Matrix2(int rowsMatrix2, int columnsMatrix2, int minValueMatrix2, int maxValueMatrix2) // матрица 2
// {
//     int[,] newArray2 = new int[rowsMatrix2, columnsMatrix2];

//     for (int i = 0; i < rowsMatrix2; i++)
//     {
//         for (int j = 0; j < columnsMatrix2; j++)
//         {
//             newArray2[i, j] = new Random().Next(minValueMatrix2, maxValueMatrix2 + 1);
//         }
//     }
//     return newArray2;
// }

// void Show2DArray(int[,] newArray1, int[,] newArray2, int[,] resultMatrix) // вывод матриц 1 и 2
// {
//     Console.WriteLine("Matrix 1:");
//     for (int i = 0; i < newArray1.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray1.GetLength(1); j++)
//         {
//             Console.Write(newArray1[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     Console.WriteLine("Matrix 2:");
//     for (int i = 0; i < newArray2.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray2.GetLength(1); j++)
//         {
//             Console.Write(newArray2[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     Console.WriteLine("Result Matrix:");
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             Console.Write(resultMatrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// bool MultiplicationCheck(int[,] newArray1, int[,] newArray2) // проверка на возможность перемножения матриц
// {
//     if (newArray1.GetLength(1) == newArray2.GetLength(0)) return true;
//     return false;
// }

// int[,] MultiplicationMatrix(int[,] newArray1, int[,] newArray2)
// {
//     if (MultiplicationCheck(newArray1, newArray2)) // если bool проверка не проходит то выдаётся следущие сообщение и програма останавливается
//     {
//         Console.WriteLine("Result of matrix multiplication:");
//         Console.WriteLine();
//     }
//     else
//     {
//         Console.WriteLine("Such matrices cannot be multiplied because the number of columns of matrix1 is not equal to the number of rows of matrix2");
//         Console.WriteLine("Enter other data");
//         Console.WriteLine();
//         return null;
//     }

//     int[,] resultMatrix = new int[newArray1.GetLength(0), newArray2.GetLength(1)];

//     for (int i = 0; i < newArray1.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray2.GetLength(1); j++)
//         {
//             for (int k = 0; k < newArray1.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += newArray1[i, k] * newArray2[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }


// Console.Write("Enter number of rows for Matrix1: ");
// int rowsMatrix1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums for Matrix1: ");
// int columnsMatrix1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue for Matrix1: ");
// int minValueMatrix1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue for Matrix1: ");
// int maxValueMatrix1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number of rows for Matrix2: ");
// int rowsMatrix2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums for Matrix2: ");
// int columnsMatrix2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue for Matrix2: ");
// int minValueMatrix2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue for Matrix2: ");
// int maxValueMatrix2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] myArray1 = Matrix1(rowsMatrix1, columnsMatrix1, minValueMatrix1, maxValueMatrix1);
// int[,] myArray2 = Matrix2(rowsMatrix2, columnsMatrix2, minValueMatrix2, maxValueMatrix2);

// MultiplicationCheck(myArray1, myArray2);

// int[,] resultMatrix = MultiplicationMatrix(myArray1, myArray2);

// Show2DArray(myArray1, myArray2, resultMatrix);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray(int rows, int columns, int depth)
// {
//     int[,,] newArray = new int[rows, columns, depth];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < depth; k++)
//             {
//                 int temp = new Random().Next(10, 100); // создаём новую переменную с рандомным числом
//                 bool foundNumber = true; // создаём проверку на найденное число (true означает что число есть в массиве)
//                 while (foundNumber) // далее проверяем массив
//                 {
//                     foundNumber = false;  // перед проверкой устанавливаем на false(числа нет в массиве)
//                     for (int l = 0; l < rows; l++)
//                     {
//                         for (int r = 0; r < columns; r++) // так же пробегаемся по всему нашему массиву
//                         {
//                             for (int m = 0; m < depth; m++)
//                             {
//                                 if (newArray[l, r, m] == temp) // проверяем равно ли значение ячеки нашему рандомному числу
//                                 { // если равно то мы создаем новое число и заново его прогоняем 
//                                     temp = new Random().Next(10, 100); 
//                                     foundNumber = true;
//                                     break; 
//                                 }
//                             }

//                         }

//                     }
//                 }
//                 newArray[i, j, k] = temp; // если в итоге чичла не оказазось мы записываем его в нужную ячейку и повторяем весь цикл
//             }
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of depth: ");
// int depth = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(rows, columns, depth);
// Show2DArray(myArray);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] Spiral2dArray(int n)
// {
//     int[,] array = new int[n, n];

//     int number = 1;
//     int i = 0;
//     int j = 0;

//     while (i < n && j < n && array[i, j] == 0)
//     {
//         array[i, j] = number;
//         number++;

//         if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
//         else if (i < j && i + j >= array.GetLength(0) - 1) i++;
//         else if (i >= j && i + j > array.GetLength(1) - 1) j--;
//         else i--;

//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



// Console.Write("Enter the size(N) of the array NxN: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Spiral2dArray(n);
// Show2DArray(myArray);


