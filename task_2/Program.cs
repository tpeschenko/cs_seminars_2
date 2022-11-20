using System;
//  Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите люболе число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = "";
int result = 0;
if (number / 100 > 0)
{
    str = number.ToString();
    Console.Write("Третья цифра введённого числа ");
    Console.WriteLine(str[2]);
}
else
{
    Console.Write("Третьей цифры нет");
}
    


