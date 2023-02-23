//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int current = 1; current <= a; current++) // current = 1 - потому что в задачи надо найти от одного(см.стр 1)
//                                                // <= a - потому что включительно с последним числом
//     {
//       sum += current // (альтернативная запись) sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of numbers from 1 to {a} = {FindSum(a)}");


//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// изменим чутка условие создадим рандомный размер массива и заполнит его случайными числами

// int[] CreateRandomArray(int size, int minValue, int maxValue) // Создаём массив на size размер(вводится пользователем) 
// {                                                             // и заполняем его рандомными числами 
//     int[] array = new int[size]; // компьютер выделяет память под массив размером size 
//     for (int i = 0; i < size; i++) // цикл для перебора массива
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); //заполняет каждый элемент мессива рандомным числом в наших рамках(min,max)
//     }// maxValue + 1 потому что если хотим чтобы в массиве было например 10 (число 10 введенное в переменную maxValue), то нужно прибавить 1
//     return array;
// }

// void ShowArray(int[] array)  // вывод массива
// {
//     for (int i = 0; i < array.Length; i++) //array.Length длинна нашего массива(см.стр 36) 
//     {
//         Console.Write(array[i]+ " ");
//     }   
//     Console.WriteLine();
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: "); 
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element: "); 
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue); // создаём новую переменную в виде массива , для того чтобы вложить 
// ShowArray(myArray);                                         // в неё результат метода CreateRandomArray 

// ShowArray(CreateRandomArray(size, minValue, maxValue)); // более быстрый и энергоёмкий способ 



//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// int FindDigit(int num)
// {
//     int i = 0;
//     while (num > 0)
//     {
//         num /= 10; // num = num / 10; 
//         i++;
//     }
//     return i;
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Your number is made up of {FindDigit(num)} numbers");



//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// int FindFactorial(int num)
// {
//     int factorial = 1;
//     for (int i = 2; i <= num; i++) // i = 2 потому что нет смысла считать 1*1 это всё равно будет 1
//     {
//         factorial *= i; // factorial = factorial * i; 

//     }
//     return factorial;
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindFactorial(num));





