﻿/*          Задача 44: Не используя рекурсию, выведите первые N чисел
            Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8         */

int SetNumber()
{
    System.Console.Write("Введите пожалуйста число: ");
    int number = Int32.Parse(Console.ReadLine());
    return number;
}


void PrintNumber(int number)
{
    System.Console.Write(number);
}

int GetNumberFibonacci(int number)
{
    int firstNumber = 0, secondNumber = 1, result = 0;

    if (number == 0) result = 0;
    if (number == 1) result = 1;
    System.Console.Write(" 0 1 ");
    for (int i = 2; i <= number; i++)
    {
        result = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = result;
        System.Console.Write($"{result} ");
    }
    return result;
}

int numberEntered = SetNumber();
int result = GetNumberFibonacci(numberEntered);

