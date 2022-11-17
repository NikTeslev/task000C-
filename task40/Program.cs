// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine(" введите три стороны");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

bool CheckSidies(int num1, int num2, int num3)
{
    bool b = num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2;
    return b;
}
bool result = CheckSidies(number1, number2, number3);
Console.WriteLine(result ? "да" : "нет");