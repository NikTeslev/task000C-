﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Проверка на чётность. Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number % 2);

if(result == 0)
{
Console.WriteLine($"{number} является чётным");
}

else Console.WriteLine($"{number} НЕ является чётным");