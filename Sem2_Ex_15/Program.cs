// Напишите программу,которая принимает на ввод цифру, обозначающую день ндли и определяет, является ли этот день выходным
System.Console.WriteLine("Введите цифру от 1 до 7, соответсвующую дню недели");
int number = Convert.ToInt32(Console.ReadLine());
if (  number > 0 && number < 6 );
{
    Console.WriteLine ("будний");
}
if (number > 5 && number < 8)
{
    Console.WriteLine ("выходной");
}