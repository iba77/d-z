// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;
 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели (1-7):");
        int dayOfWeek = int.Parse(Console.ReadLine());
         if (dayOfWeek >= 1 && dayOfWeek <= 7)
        {
            if (dayOfWeek == 6 || dayOfWeek == 7)
            {
                Console.WriteLine("Этот день является выходным.");
            }
            else
            {
                Console.WriteLine("Этот день не является выходным.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный номер дня недели. Введите число от 1 до 7.");
        }
    }
}