// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

 if(number2 < 0 )
    {
       number2 = number2 * -1;
    }

int ResNumber(int num1, int num2)
{
    int result = 1;
   
    
       for (int i = 1; i <= num2; i++)
        {
           
           result = result * num1;
        }
        
    return result;

}
int resNumber = ResNumber(number1, number2);
System.Console.WriteLine(resNumber);