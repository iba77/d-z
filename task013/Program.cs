// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = (number / 1) % 10;
        if (number < 100)
        {
            Console.WriteLine("третьей цыфры нет.");
        }
        else
        {
            Console.WriteLine($"Третяя цифра числа: {thirdDigit}");
        }
    }
}