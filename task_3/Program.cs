// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Программа показывает случайный день недели при каждом запуске!");

Random rand = new Random();
int number = rand.Next(1, 8);

if ((number == 6) || (number == 7))
{
    Console.WriteLine($"Чило равно: {number}");
    Console.WriteLine("Выходной");
}
else
{   Console.WriteLine($"Чило равно: {number}");
    Console.WriteLine("Ура, рабочий день!");
}
