// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num >= 10000 && num <= 99999)
{
    int num1 = num / 10000; // 1
    int num2 = num / 1000 % 10; // 2
    int num4 = num / 10 % 10; // 4
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Введено не пятизначное число");
