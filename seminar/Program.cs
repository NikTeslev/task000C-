void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


//
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElem = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveNegativeElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {getSumPositiveNegativeElem[1]}");





// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


bool Find(int[] array, int find1)
{
    bool b = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find1)
        {
            b = true;
            break;
        }
    }
    return b;
}


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]= rnd.Next(min,max+1);
    }   
    return array;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1)Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool Find(int[] array, int find1)
{
    bool b = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find1)
        {
            b = true;
            break;
        }
    }
    return b;
}


int[] array = CreateArrayRndInt(20, 0, 80);
PrintArray(array);

Console.WriteLine("Пожалуйста, введите искомый элемент");
int elem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(  Find(array, elem)? "Да" : "нет");


//задача 35
// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int GetCountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(123, 0, 200);
PrintArray(arr);
int result = GetCountElements(arr);
Console.WriteLine($"Количество элементов массива, из отрезка [10,99] = {result}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] MultiplicationNumbers(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size = size + 1;
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
        return newArray;
}


int[] arr = CreateArrayRndInt(10, 1, 9);
PrintArray(arr);

int[] res = MultiplicationNumbers(arr);
PrintArray(res);





//метод для дробных чисел

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
