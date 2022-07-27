// Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNumbersRecursion(int start, int end, int sum = 0)
{
    if (start > end)
    {
        return sum;
    }
    sum += start;
    start++;
    return SumNumbersRecursion(start, end, sum);
}
int startNumber = 0;
int endNumber = 0;
string intError = "ВВЕДИТЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n";
string message1 = "Введите начальное число: ";
string message2 = "Введите конечное число: ";
Console.Write(message1);
while (!int.TryParse(Console.ReadLine(), out startNumber))
{
    Console.WriteLine(intError);
    Console.Write(message1);
}
Console.Write(message2);
while (!int.TryParse(Console.ReadLine(), out endNumber))
{
    Console.WriteLine(intError);
    Console.Write(message2);
}
Console.Write($"Сумма элементов в промежутке от {startNumber} до {endNumber}\nРавна: ");
Console.WriteLine(SumNumbersRecursion(startNumber, endNumber));
