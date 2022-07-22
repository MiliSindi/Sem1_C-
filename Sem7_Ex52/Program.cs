// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] GetMatrix(int rows, int columns, int min = 0, int max = 9)
{
    double[,] matrix = new double[rows, columns];
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

void PrintMatrix(double[,] matrix)
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

void SearchValue(double[,] matrix)
{
    double[] sum = new double[matrix.GetLength(1)];
    double[] avg = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum[j] += matrix[i, j];
        }
        avg[j] = sum[j] / matrix.GetLength(0);
        Console.WriteLine("{0,4:F2}", avg[j]);
    }
}

var rand = new Random();
int rows = rand.Next(3, 10);
int columns = rand.Next(3, 10);

Console.WriteLine($" Задан массив: [{rows},{columns}]");
double[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
SearchValue(result);
