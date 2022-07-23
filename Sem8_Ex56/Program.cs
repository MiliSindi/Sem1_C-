// Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rows, int columns, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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

int[] GetSumStringMatrix(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
    }
    return sum;
}

void PrintMinSumStringMatrix(int[] sum)
{
    int min = sum[0];
    int numString = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        Console.WriteLine($"строка {i + 1} с суммой элементов {sum[i]}");
        if (min > sum[i])
        {
            min = sum[i];
            numString = i;
        }
    }
    Console.Write($"\nСтрока с наименьшей суммой элементов\"{numString + 1}\"");
}

int rows = 0;
int columns = 0;
string intError = "ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string inputMessage1 = "Введите количество строк в массиве: ";
string inputMessage2 = "Введите количество столбцов в массиве: ";

Console.Write(inputMessage1);
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine(intError);
    Console.Write(inputMessage1);
}
Console.Write(inputMessage2);
while (!int.TryParse(Console.ReadLine(), out columns))
{
    Console.WriteLine(intError);
    Console.Write(inputMessage2);
}
int[,] result = GetMatrix(rows, columns);

Console.WriteLine($"\nЗадан массив [{rows},{columns}]");
PrintMatrix(result);
int[] sumStringMatrix = GetSumStringMatrix(result);
PrintMinSumStringMatrix(sumStringMatrix);
