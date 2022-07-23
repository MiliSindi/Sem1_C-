//Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] GetMatrix(int size)
{
    int[,] matrix = new int[size, size];
    int value = 1;
    int i = 0, j = 0, n = matrix.GetLength(1);
    while (n != 0)
    {
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i, j++] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i++, j] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i, j--] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            matrix[i--, j] = value++;
        }
        if (matrix[n / 2, n / 2] == 0)
        {
            matrix[n / 2, n / 2] = n * n;
        }
        n = n < 2 ? 0 : n - 2;
        ++i; ++j;
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

int size = 0;
string intError = "ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string inputMessage1 = "Введите размер квадратного двумерного массива: ";

Console.Write(inputMessage1);
while (!int.TryParse(Console.ReadLine(), out size))
{
    Console.WriteLine(intError);
    Console.Write(inputMessage1);
}

Console.WriteLine($"Задан массив [{size},{size}]");
PrintMatrix(GetMatrix(size));

