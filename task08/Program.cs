//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 0;

if (number > 0)
    while (count <= number)
    {
        result = count % 2;
        if (result == 0)
        {
            Console.WriteLine($"{count}");

        }
        count++;
    }
else
{
     Console.WriteLine("Введите положительное число");
}