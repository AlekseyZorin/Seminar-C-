//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreatRandomArray(int size, int minValue, int maxValue) // создаёт массив
// {
//     int[] array = new int[size];    // выделение памяти под массив
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

// void FindPosNegSum(int[] array) //считае сумму положительных элементов и сумму отрицательных элементов 
// {
//     int sumPositiv = 0;  // сумма положительных элеметов
//     int sumNegativ = 0;  // сумма отрицательных элементов
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPositiv += array[i]; // если элемент массива больше или равен нулю, то в переменную sumPositiv прибавляем этот элемент массива 
//         else sumNegativ += array[i]; // если нет то добавляем этот элемент в переменную sumNegativ 
//     }
//     // т.к. нет retutn  то надо что то вывести в консоль и мы выводим следущее сообщение
//     Console.WriteLine($"Sum of positive numbers in array -> {sumPositiv}, sum of negative numbers in array -> {sumNegativ}");
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, minValue, maxValue); // записываем в новый массив то что сгенерировалось в методе CreatRandomArray, иначе эти данные остануться без вывода
// ShowArray(myArray);   // т.к. мы наш массив присвоили переменной myArray то ее мы потом и вызываем 
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

// int[] InvertArray(int[] array) // заменяем положительный элемент на отрицательный и наоборот
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);  // чтобы поменять знак элемента нужно каждый элемент массива умножить на -1
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
// myArray = InvertArray(myArray);  // перезаписываем массив новым перевёрнутым массивом, тем самым старый(первоначальный) массив удаляется
// ShowArray(myArray); // и выводим соответственно новый перевёрнутый массив 




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
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void FindNumber (int[] array, int number)
// {
//     int k = 0;                             // k - это счётчик, который мы вводим для остановки цикла
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)   // если элемент массива будет равен заданному числу 
//         {
//                 k = 1; // то K будет равен одному, как бы показывает что минимум одно число присутствует в данном массиве 
//                 break; // и после этого мы останавливаем цикл for и выходим из него, чтобы не проверять оставшиеся элементы 
//         }
//     }
//     if (k == 1)  // и если К будет равен 1 то выводим что в массиве присутствует указанное число
//     {            // ну а если К останется равен 0 то значит указанного числа в массиве нет 
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
// FindNumber(myArray, number);


// Вариант задачи где нам показывают на каком индексе массива находятся число(если их много) и выдаёт общее количество совпадений
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

// void FindNumber(int[] array, int number)
// {
//     int k = 0;
//     // k - это счётчик, который мы вводим для остановки цикла
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             k++;
//             Console.WriteLine($"{i} -> {number}");
//         }
//     }
//     if (k > 0) Console.WriteLine($"Total {k}");
//     else Console.WriteLine($" Not number {number}");
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
// FindNumber(myArray, number);



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
//     {    // определяем диапозон чисел в котором будут искаться соответствия 
//         if (array[i] >= minNumber && array[i] <= maxNumber ) // либо вместо переменных minNumber и maxNumber можно было
//         {                                              // поставить числа 10 и 99 (по условию задачи) и тогда эти переменные вводить не надо
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