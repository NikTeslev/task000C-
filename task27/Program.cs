// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());

 int SumDigit(int numDigit)
 {
     int count = 0;
     while (numDigit > 0)
     {
        // numDigit = numDigit % 10;
         count = count + (numDigit % 10);
         numDigit = numDigit / 10;
     }
     return count;
 }
 int sumDigit = SumDigit(num);
 Console.WriteLine($"Cумма цифр в числе = {sumDigit}");

