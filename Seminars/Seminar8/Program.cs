//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2
//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ ОН БУДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ


// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
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

// int[,] ChangeRows(int[,] array, int row1, int row2)  // метод который меняет строчки местами
// {                // row1 и row2 - номера строк(которые вводит пользователь) которые будут меняться местами 
//     row1--;  // row1-- row2-- делается для того чтобы для обычног пользователя первая строка начиналась с 1, а не с 0
//     row2--;  // тем самым  у первой строки индекс будет "как-бы" 1 а не 0
//     // делаем проверку на наличие номера строки которой вводит пользователь
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
//     { // если номера строк больше имеющего или наоборот введено отрицательное число то выводится сообщение об ошибке и возращается неизменёный массив
//         Console.WriteLine("Invalid row");
//         return array;
//     }
//     else // если все введено правильно в рамках нашего массива то переходим к следущему циклу
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // идём по столбцам, т.к. строки у нас закреплены нашими переменными row1 и row2
//         { // поэтому мы движемся слева на право по строке а именно по столбцам 0,0-0,1-0,2-0,3(индексы 1 строки) в нашем случае row1,0-row1,1-row1,2-row1,3
//                                // наприме перую  меняем с четверой строкой     3,0-3,1-3,2-3,2(индексы 4 строки) в нашем случае row2,0-row2,1-row2,2-row2,3
//             int temp = array[row1, j];                    
//             array[row1, j] = array[row2, j];  // создаём временную переменную туда вписываем значение первого столбца первой строки
//             array[row2, j] = temp; // в значение первого столбца первой строки вписываем значение второй строки первого столбца 
//             // и в значение второй строки первого столбца вписываем нашу переменную temp и так по очереди меняем каждое значение
//         }
//     }
//     return array;

// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of first row to change: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of second row to change: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = ChangeRows(myArray, row1, row2);
// Show2DArray(myArray);


//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//В итоге получается вот такой массив:
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
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

// int[,] RowsToColumns(int[,] array) // меняем строки и столбцы местами
// { // возможно только если количество строк равно количеству столбцов
//     if (array.GetLength(0) != array.GetLength(1)) // если количество строк не равно количеству столбцов
//     {
//         Console.WriteLine("Rows and columns must be equal"); //то выводим сообщение об ошибке и возвращаем нетронутый массив
//         return array;
//     }
//     else // если количество строк равно количеству столбцов то переходим к циклу
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++) //array.GetLength(0) - 1(по сути можно и без -1 программа будет работать)
//         {  // но из оптимизации программы лучше делать -1 из-за того что последний цикл идёт в холостую, так как остаётся только одна 
//            // угловая нижняя цифра которую не с кем менять 
//             for (int j = i + 1; j < array.GetLength(1); j++) //j = i + 1 из того что мы с каждой строчки начинаем менять со 
//             {  // следующей цифры в строке по порядку тоесть в данном случае со следущего столбца(как бы идя по главной диогонали)
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i]; // на array[j, i] из-за то что по сути индексы цифр которые мы меняем зеркальны 
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// Show2DArray(RowsToColumns(myArray));


//Задание 3. Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
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

// int[,] FindMinNum(int[,] array) // заменяет перекрестье с минимальным значением на нули
// {
//     int minNum = array[0, 0]; // обьявляем три переменных в которые будут записываться минимальное число и отдельно его индексы
//     int minI = 0; // минимальному присваиваем значение первого числа(индексы 0,0 соотвено)
//     int minJ = 0; // ну и обозначаем переменные индексов соответственно тоже 0ми
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minNum) //при "<" будет находить первое наименьшее(при случае если в массиве окажется несколько наименьших значений)
//             { // при "=" последнее значение
//                 minNum = array[i, j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++) // обнуляем строчку в которой наименьшее значение
//     {
//         array[i, minJ] = 0;
//     }
//     for (int j = 0; j < array.GetLength(1); j++) // обнуляем столбец в котором наименьшее значение
//     {
//         array[minI, j] = 0;
//     }
    
//     // либо через двойной цикл For
//     // for(int i = 0; i < array.GetLength(0); i++)
//     // {
//     //     for (int j = 0; j < array.GetLength(1);j++)
//     //     {
//     //         if(i == minI || j == minJ) array[i,j] = 0;
//     //     }
//     // }
//     return array;
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArray(myArray);
// Console.WriteLine();
// Show2DArray(FindMinNum(myArray));

