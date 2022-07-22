// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] GetMatrix(int rows, int columns, int min = 0, int max = 10)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * max;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}\t", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int rows = 0;
int columns = 0;

Console.Write("Введите число строк: ");
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите число строк: ");
}
Console.Write("Введите число столбцов: ");
while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.ResetColor();
    Console.Write("Введите число столбцов: ");
}


System.Console.WriteLine($"Получен двумерный массив[{rows},{columns}]");
Console.ForegroundColor = ConsoleColor.Yellow;
PrintMatrix(GetMatrix(rows, columns));
Console.ResetColor();
