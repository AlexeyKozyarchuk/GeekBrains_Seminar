/* 1. Напишите программу, которая на вход принимает два
      числа и проверяет, является ли первое число квадратом второго.

a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет     */

void isSecondNumberSquaredIsEqualToFirst()
{
System.Console.WriteLine("Напишите, пожалуйста, первое число: ");
int numberFirst = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Напишите, пожалуйста, второе число: ");
int numberSecond = Int32.Parse(Console.ReadLine());
int numberSecondSquared = numberSecond * numberSecond;

System.Console.Write($"a = {numberFirst}, b = {numberSecond}");
if (numberSecondSquared == numberFirst) System.Console.WriteLine($" -> да");
else System.Console.WriteLine($" -> нет");
}

isSecondNumberSquaredIsEqualToFirst();