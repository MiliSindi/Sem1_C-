// Напишите программу, которая на вход принимает трехзначное значение, а на выходе выдает вторую цифру этого числа
System.Console.WriteLine ("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000);
{
    Console.WriteLine (number % 100 /10);
}