// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Print three-digit number: "); // Просим ввести трехзначное число
// int num = Convert.ToInt32(Console.ReadLine());  // присваиваем введенное число переменной num и конвентируем её сразу в intовый тип
// //bool chec = CheckNumber(num);    // создаём ещё одну переменную chec и присваиваем ез значение Метода ChecNumber(в скобках наша переменная num(число которое мы ввели))
// //Console.WriteLine(chec);    // если хотим чтобы результат Метода ChecNumber(а именно True или False) выводился к терминале  
// // либо можно записать 9 и 10 строчки в одну ввиде Console.WriteLine(ChecNumber), но только если переменой num присвоенно какое либо значение внутри кода(не вписано в консоль пользователем)

// bool CheckNumber(int num)  // первый Метод - проверка числа на трёхзначность // в скобках наша переменная num(число которое мы хотим проверить)
// {                                  // тип данных bool принимает какое то условие и выдаёт либо true(правдиво) либо false(ложно) данное утверждение
//     if (num > 99 && num < 1000)    // в данном случае мы проверяем правда ли число введеное пользователем трёхзначное 
//     {
//       return true;  // если число подходит под параметры тогда true 
//     }
//       return false;  // если нет тогда false
// }

// if (CheckNumber(num))                // далее мы делаем проверку на подходит ли нам данное число 
// {
//     Console.WriteLine("Answer ");           // и если в Методе на проверку трёхзначности выдаёт True то мы видим в терминале сообщение Answer 
//     Console.WriteLine(MiddleNumber(num));   // и программа переходит к выполнению Метода MiddleNumber и сразу выдаёт его результат 
// }
// else                                      // если мы Методе ChekNumber получаем ответ False то  
// {  
//     Console.WriteLine("This is not a three digit number"); // переходим сюда в терминар выдаются следующие сообщения и программа заканчивает свою работу
//     Console.WriteLine("Enter another number");
// }


// int MiddleNumber(int num)                  // Метод  определение второй цифры введеного числа
// {                                       // к этому Методу переходим только если первый выдал значение True
//     int secondNum = num % 100 / 10;    // вводим новую переменную secondNum и придаем ей значение остаток от деления нашего числа разделённого на десять

//     return secondNum;   // и возращаем нашему Методу значение переменной secondNum для того чтобы при выводе в терминал
//                      // (или использование данного Метода где либо ещё) использовалось значение которое мы им получили
// }


// Задача 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Print number");
// int num = Convert.ToInt32(Console.ReadLine());

// bool Number(int num)
// {
//     if (num < 100)
//     {
//         return true;
//     }
//     return false;
// }

// if (Number(num))
// {
//     Console.WriteLine($"Third digit in {num} no");
// }
// else
// {
//     Console.WriteLine("Third digit of a given number ");
//     Console.WriteLine(ThirdNumber(num));
// }

// int ThirdNumber(int num)
// {
//     while (num > 999)
//     {
//         if (num > 999)
//         {
//             num = num / 10;
//         }    
//     }
//     num = num % 10;
//     return num;
// }


// Задача 3
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет 

// Console.WriteLine("Print number 1 to 7");
// int num = Convert.ToInt32(Console.ReadLine());

// bool Namber(int num)
// {
//     if (num < 1 || num > 7)
//     {
//         return true;
//     }
//     return false;
// }

// if(Namber(num))
// {
//     Console.WriteLine($"Not that number");
// }
// else 
// {
//     Console.WriteLine(Day(num));
// }

// int Day(int num)
// {
//     if (num <= 5)
//     {
//         Console.WriteLine("Workday");
//         return num;
//     }
//     else 
//     {
//         Console.WriteLine("Holiday");
//         return num;
//     }
// }