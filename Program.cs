//Задача 10.Напишите программу,которая выводит случайное трехзначное число и на выходе показывает вторую цифру этого числа.

// 456 ->5

// 782 ->8

// 918 ->1

//int Prompt(string message)
//{

//System.Console.Write("message");
//string value = Console.ReadLine();
//int result = Convert.ToInt32(value);
//return result;
//}
//int number = Prompt("input three-digit number");
//if (number < 100 && number >=1000)
//{
  //  Console.WriteLine("It is not three-digit number");
    //return;
//}
//Console.WriteLine($"enter '{number}'");
//int secondRank = number / 10 % 10;
//Console.WriteLine($"Second is '{secondRank}'");

//Задача 13.Напишите программу,которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 ->5

// 78 ->третьей цифры нет

// 32679 ->6

//int Prompt(string msg)
//{

//System.Console.WriteLine($"{msg}");
//return Convert.ToInt32(Console.ReadLine());
//}
//int number = Prompt("Input number");

//int fnumber(int number)
//{
//while (number > 999)
//{
//number /= 10;
//}
//return number % 10;
//}

//bool check(int number)
//{
//if (number < 100)
//return false;
//else return true;
//}

//if (check(number) != true)
//System.Console.WriteLine("Third number is not");
//else
//System.Console.WriteLine($"Third {number} is {fnumber(number)}");

//Задача 16.Напишите программу,которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 ->да

// 7 ->да

// 1 ->нет


int Prompt(string message)
{

System.Console.WriteLine($"{message}");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("input number");
string ss = "this is not a week";
string check(int number)
{
if (number >= 6 && number < 8) ss = "it is a weekend";
if (number >= 1 && number < 6) ss = "it is a work day";
return ss;
}
System.Console.WriteLine(check(number));