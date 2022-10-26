Console.WriteLine("Сравнить, какое больше. Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if(number2 > number1)
{
Console.WriteLine($"{number2} Больше");
}
else if(number1>number2)
{
Console.WriteLine($"{number1} больше");
}
else Console.WriteLine("числа равны");