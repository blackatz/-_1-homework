﻿// напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка)

Console.WriteLine("Программа вычисления четного числа.");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number%2 == 0)
{
    Console.WriteLine("Да");
}

else 
{
    Console.WriteLine("Нет");
}