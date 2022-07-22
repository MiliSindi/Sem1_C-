// Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] GetMatrix(int rows, int columns, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SearchPosition(int[,] matrix, int x, int y)
{
    try
    {
        Console.WriteLine($"\nВ данной ячейке находится значение: {matrix[x, y]}");
    }
    catch
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

var rand = new Random();
int rows = rand.Next(3, 10);
int columns = rand.Next(3, 10);

int row = 0;
int column = 1;
Console.Write("Введите номер строки в массиве: ");
while (!int.TryParse(Console.ReadLine(), out row))
{
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.Write("Введите номер строки в массиве: ");
}
Console.Write("Введите номер столбца в массиве: ");
while (!int.TryParse(Console.ReadLine(), out column))
{
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.Write("Введите номер столбца в массиве: ");
}


Console.WriteLine($"Задан массив [{rows},{columns}]");

int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
SearchPosition(result, row, column);

