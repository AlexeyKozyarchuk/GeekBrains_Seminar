﻿/* 5. Напишите программу, которая на вход принимает
      одно число (N), а на выходе показывает все целые
      числа в промежутке от -N до N.

4 ->  "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 ->  "-2, -1, 0, 1, 2"                   */

System.Console.WriteLine("Здравствуйте, пожалуйста, введите число: ");
int number = Int32.Parse(Console.ReadLine());
int count = 0;

for (int i = -number; i <= number; i++)
{
    int result = -number + count;
    if (i == -number)
    {
        System.Console.Write(number + " -> " + '"');
    }
    if (i == number)
    {
        System.Console.Write(result);
        System.Console.Write('"');
        break;
    }
    System.Console.Write($"{result}, ");
    count++;
}