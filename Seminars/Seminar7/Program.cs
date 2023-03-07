//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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
//             Console.Write(array[i, j]+ " ");

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(array);



//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,] Create2DArray(int columns, int rows)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = i+j;
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
//             Console.Write(array[i, j]+ " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// Show2DArray(Create2DArray(colums, rows));



//Задача 3.Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:
//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

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
//             Console.Write(array[i, j]+ " ");

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] DoubleNewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0)

//             {
//                 array[i, j] = Convert.ToInt32(Math.Pow(array[i, j], 2));

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

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

// Show2DArray(array);
// Show2DArray(DoubleNewArray(array));



//Задача 4. Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2                      Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12


int[,] Create2DRandomArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumDiagonalElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) 
            {
                sum += array[i, j];
            }
        }
    }
    Console.WriteLine(sum);
}

// Вариант с другим методом 
// void sumOfDiagonale(int[,] array)
// {
//     int totsum = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         totsum += array[i,i];
//     }
//      Console.WriteLine($"Summarize of elements on the main diagonale is {totsum}");
// }

// Третий способ 
// void Sum (int[,] array)
// {
//     int summa = 0;
//     for (int i = 0, j = 0; i < array.GetLength(0); i++, j++)
//     {
//         summa = summa + array[i,j];
//     }
//     Console.WriteLine($"Сумма элементов по диагонали равна {summa}");
// }

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);

Show2DArray(array);
SumDiagonalElements(array);
