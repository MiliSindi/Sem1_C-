// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int[,,] GetMatrix(int rows, int columns, int z, int min = 0, int max = 10)
{
    int[,,] matrix = new int[rows, columns, z];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ");
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int coub = 0;

Console.Write("Введите размер трёхмерного массива (куб): ");
while (!int.TryParse(Console.ReadLine(), out coub))
{
    Console.WriteLine("ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.Write("Введите размер трёхмерного массива (куб): ");
}

Console.WriteLine($"Задан трёхмерный массив [{coub}, {coub}, {coub}]");;
int[,,] result = GetMatrix(coub, coub, coub);
PrintMatrix(result);
