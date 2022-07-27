//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

int numberFirst = 2;
int numberSecond = 3;

int FunctionAkkermanRecursiv(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkkermanRecursiv(m - 1, 1);
    else if (m > 0 && n > 0) return (FunctionAkkermanRecursiv((m - 1), FunctionAkkermanRecursiv(m,( n - 1))));
    else return 0;
}
Console.WriteLine($"A(m,n) = {FunctionAkkermanRecursiv(numberFirst, numberSecond)}");
