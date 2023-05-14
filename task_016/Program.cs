/* 16. Напишите программу, которая принимает на вход два числа
       и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет        */

// РЕШЕНИЕ ВЗЯТО С ПЕРВОЙ ЗАДАЧИ https://github.com/AlexeyKozyarchuk/GeekBrains_Seminar/blob/main/task_001/Program.cs

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