// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreatRandomArray(int size) // создаёт массив
// {
//     int[] array = new int[size];    // выделение памяти под массив
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999 + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array) // выводит массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int EvenNumber(int[] array)  // определяем чётные числа
// {
//     int amount = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) amount++;
//     }
//     return amount;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size);
// ShowArray(myArray);

// Console.WriteLine($"Even number in array -> {EvenNumber(myArray)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача на нахождение суммы нечётых чисел массива
// int[] CreatRandomArray(int size, int minValue, int maxValue) // создаёт массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array) // выводит массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddNumber(int[] array)  // определят сумму нечётных чисел
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 != 0) sum += array[i];
//     }
//     return sum;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine($"Sum odd number in array -> {SumOddNumber(myArray)}");

//Задача на нахождение суммы нечётных элементов массива 
// int[] CreatRandomArray(int size, int minValue, int maxValue) // создаёт массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array) // выводит массив
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int SumOddNumber(int[] array)  // определят сумму нечётных чисел
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     return sum;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine($"Sum odd number in array -> {SumOddNumber(myArray)}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// double[] CreatRandomArray(int size) // создаёт массив
// {
//     double[] array = new double[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(minValue, maxValue + 1) + Math.Round(rand.NextDouble(), 2);
//     }
//     return array;
// }

// void ShowArray(double[] array) // выводит массив
// {
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i] + "  ");
//     }
//     Console.WriteLine();
// }

// double MaxAndMin(double[] array) // вычисляем разницу между макс. и мин. элементами массива
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }
//     for (int i = 0; i < size; i++) // этот цикл так же можно запихнуть в первый на стр.173 под if
//     {
//         if (array[i] < min) min = array[i];
//     }
//     double difference = Math.Round(max - min, 2);
//     return difference;    
// }

// double[] myArray = CreatRandomArray(size);
// ShowArray(myArray);
// Console.WriteLine($"Difference between max and min -> {MaxAndMin(myArray)}");




