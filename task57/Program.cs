// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
// |   10 |   -9 |    7 |    6 |    6 |   -4 |
// |    6 |   -7 |   -8 |   -3 |    2 |   -6 |
// |   -2 |   -3 |   -9 |    0 |    8 |   -5 |

int[] MatrixToArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           
            newArray[k] = matrix[i, j];
            
            k++;
        }
    }
    return newArray;
}

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
void Dictionary

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
 PrintMatrix(array2D);
Console.WriteLine();
 int[] newArr = MatrixToArray(array2D);
Array.Sort(newArr);


 PrintArray(newArr);

