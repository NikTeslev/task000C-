// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 
        {
            matrix[i, j] = i + j; // 2 - 3
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j], 5}");
        }
        Console.WriteLine(" |");
    }
}
void ChangeQuadratMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) // 2
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) // 
        {
           //if (i % 2 == 0 && j % 2 == 0)
           //{
            matrix[i, j] = matrix[i, j] * matrix[i, j];
           //} 
        }
    }

}
int[,] array2D = CreateMatrixRndInt(3, 6, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
ChangeQuadratMatrixInt(array2D);
PrintMatrix(array2D);
