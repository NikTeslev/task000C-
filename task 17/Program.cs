//Задача 18: Напишите программу, которая по 
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quat = Convert.ToInt32(Console.ReadLine());

string Range(int quater)
{
    if (quater == 1) return "x > 0;  y > 0";
    if (quater == 2) return "x < 0;  y > 0";
    if (quater == 3) return "x < 0;  y < 0";
    if (quater == 4) return "x > 0;  y < 0";
    return "некорректные данные";
}
string range = Range(quat);
Console.WriteLine(range);

//Math.Sqrt(45); извлечение корня
//




// Console.Write("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double Range(int x11, int y11, int x21, int y21)
// {
//     int rangeX = x11 - x21;
//     int rangeY = y11 - y21;
//     double rangeZ = Math.Sqrt(rangeX * rangeX + rangeY * rangeY);
//     return rangeZ;
// }

// double result = Range(x1, y1, x2, y2);
// Console.Write($"А ({x1},{y1}); B ({x2},{y2}) -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
