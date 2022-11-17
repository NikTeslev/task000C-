// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] NewArray(int size);
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.length; i++)
    {
        array[i] = rnd.Next(99, 1000);
    } 

}
void PrintArray(int array);
Console.Write("[");
for (int i = 0; i < array.length; i++)
{
    Console.Write($"{array[i]}");
}
Console.Write($"{array[i]}");