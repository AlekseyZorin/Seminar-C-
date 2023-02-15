// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Print three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckNumber(num);

// void CheckNumber(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//       Console.WriteLine("Answer ");
//     }
//     else
//     {
//       Console.WriteLine("This is not a three digit number"); 
//     }
// }

// int MiddleNumber(int numb)
// {
//     int secondNum = num % 100 / 10;

//     return secondNum;
// }
// Console.WriteLine(MiddleNumber(num));



Console.WriteLine("Print three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
bool chec = CheckNumber(num);
Console.WriteLine(chec);

bool CheckNumber(int num)  // проверка числа на трёхзначность
{
    if (num > 99 && num < 1000)  
    {
      Console.WriteLine("Answer ");
      return true;
    }
      Console.WriteLine("This is not a three digit number");
      return false;  
}
if (CheckNumber(num))
{
    Console.WriteLine(MiddleNumber(num));
}
else
{
    Console.WriteLine("Enter another number");
}


int MiddleNumber(int numb)  // определение его второй цифры
{
    int secondNum = num % 100 / 10;

    return secondNum;
}












