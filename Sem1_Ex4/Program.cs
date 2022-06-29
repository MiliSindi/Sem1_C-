// Напишите программу, которая на вход принимает 3 числа, а на выход выдает большее из них.
int numberA = 2;
int numberB = 5;
int numberC = 7;
int numberMax = 0;

if (numberA > numberMax)
{
numberMax = numberA;
}
else if (numberB > numberMax)
{
numberMax = numberB;
}
else if (numberC > numberMax)
{
numberMax = numberC;
}
else
{
  Console.WriteLine(numberMax);  
}
