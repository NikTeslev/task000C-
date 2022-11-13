// Задача 24: Напишите программу, которая
// 1.принимает на вход число (А) 
// 2.и выдаёт сумму чисел
// от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    // int sum=0;        
    // count=0;
    // while (count <=number) { 

    //     sum+=count;
    // }
    // count++;

    int sum=default;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;    
}


int result = SumNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} => {result}");



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int sum = default; // 0

    for (int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumbers}");


//26

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit(int numDigit)
// {
//     int count = 0;
//     while (numDigit > 0)
//     {
//         numDigit = numDigit / 10;
//         count++;
//     }
//     return count > 0 ? count : 1;
// }
// int sumDigit = SumDigit(num);
// Console.WriteLine($"Количество цифр в числе = {sumDigit}")



// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit(int numDigit)
// {
//     numDigit = Math.Abs(numDigit);
//     int count = 0;
//     while (numDigit > 0)
//     {
//         numDigit = numDigit / 10;
//         count++;
//     }
//     return count > 0 ? count : 1;
// }
// int sumDigit = SumDigit(num);
// Console.WriteLine($"Количество цифр в числе = {sumDigit}");


//28

// Console.WriteLine("Введите число: ");
// int numNr = Convert.ToInt32(Console.ReadLine());
// if (numNr > 0)
// {
//     int productOfNumbers = ProductOfNumbers(numNr);
//     Console.WriteLine($"Произведение чисел от 1 до {numNr} = {productOfNumbers}");
// }
// else
// {
//     Console.WriteLine("Вы ввели некорректное число");
// }

// int ProductOfNumbers(int numProduct)
// {
//     int multNum = 1;
//     for (int i = 1; i <= numProduct; i++)
//     {
//         multNum = multNum * i;
//     }
//     return multNum;
// }


// 30


// int[] array = new int [8];
// for (int i = 0; i < array.Length; i++)
// {
//   int random  = new Random().Next(0, 2);
//   Console.Write($"{random} ");
// } 

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.WriteLine("Введите количество элементов массива : ");
int num = Convert.ToInt32(Console.ReadLine());

int[] NameArray(int size)
{
    int[] array = new int[size]; //
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i>array.Length-1) Console.Write(",");
    }
    Console.Write("]");
}

int[] nameArray = NameArray(num);
PrintArray(nameArray);

