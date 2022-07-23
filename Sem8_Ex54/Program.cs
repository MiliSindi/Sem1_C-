// Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] GetOrderedStrings(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1) - 1; l++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j + 1 == matrix.GetLength(1))
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[i, j] < matrix[i, j + 1])
                        {
                            int temp = matrix[i, j + 1];
                            matrix[i, j + 1] = matrix[i, j];
                            matrix[i, j] = temp;
                        }
                    }

                }
            }
        }
    }
    return matrix;
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
Console.WriteLine($"\nМассив отсортирован\n");
int[,] orderMatrix = GetOrderedStrings(result);
PrintMatrix(orderMatrix);

