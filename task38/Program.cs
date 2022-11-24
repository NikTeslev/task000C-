// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRnd(int size, int min, int max)
  {
      double[] array = new double[size];
      Random rnd = new Random();
      for (int i = 0; i < size; i++)
      {
          double num = rnd.NextDouble() * (max - min) + min;
          array[i] = Math.Round(num, 2);
      }
      return array;
  }

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} |");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double DiffOfMinAndMax(double[] array)
{
    double diff = default;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    
    }
    diff = max - min;
    return diff;
}
double[] arr = CreateArrayRnd(6, 1, 9);
PrintArray(arr);
double difference = DiffOfMinAndMax(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным числом равна - {difference}");