﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.WriteLine("Введите число");
string text = Console.ReadLine();
int number = int.Parse(text);

if (number % 2 == 0)
{
    System.Console.WriteLine($"Да, {number} - четное число");
}
else
{
    System.Console.WriteLine($"Нет, {number} - нечетное число");
}
