// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix(int rows, int columns, int min = 1, int max = 10)
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
int[,] ProductMatrix(int[,] fFactor, int[,] sFactor)
{
    int[,] product = new int[fFactor.GetLength(0),fFactor.GetLength(1)];
    for (int i = 0; i < fFactor.GetLength(0); i++)
    {
        for (int j = 0; j < fFactor.GetLength(1); j++)
        {
            product[i,j] = fFactor[i,j] * sFactor[i,j];
        }
    }
    return product;
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
int[,] firstFactor = GetMatrix(rows, columns);
int[,] secondFactor = GetMatrix(rows, columns);
Console.WriteLine($"\nЗадано два массива [{rows},{columns}]\nсо случайными числами от 1 до 9");
PrintMatrix(firstFactor);
Console.WriteLine();
PrintMatrix(secondFactor);
Console.WriteLine($"\nПроизведение двух мартиц");
int[,] productMatrix = ProductMatrix(firstFactor, secondFactor);
PrintMatrix(productMatrix);

