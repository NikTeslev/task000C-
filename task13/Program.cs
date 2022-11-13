// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 100;

while ((number / count) > 0) // (number > 99)
{
    count = count * 10;
}
    if (number > 99)
    {
      int thirdDigit = (number % (count / 100)); // (count / 10));
        Console.WriteLine($"{number} => {thirdDigit / (count / 1000)}");
        System.Console.WriteLine(count);
    }
else
{
    Console.WriteLine("Нет третьей цифры");
}


