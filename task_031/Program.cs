﻿/*      Задача 31: Задайте массив из 12 элементов, заполненный
        случайными числами из промежутка [-9, 9]. Найдите сумму
        отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна -20.       */

int[] FillArray()
{
    int size = 12;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 9);
    }
    return array;
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    System.Console.Write("[");

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{collection[i]}]");
            break;
        }
        System.Console.Write($"{collection[i]},");
    }
}

void GetSumOfPositiveElements(int[] collection)
{
    int sum = 0;
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        if (collection[i] > 0) sum += collection[i];
    }
    System.Console.Write($"\nсумма положительных чисел равна {sum}, ");
}

void GetSumOfNegativeElements(int[] collection)
{
    int sum = 0;
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        if (collection[i] < 0) sum += collection[i];
    }
    System.Console.Write($"сумма отрицательных равна {sum}.\n");
}

int[] array = FillArray();
PrintArray(array);
GetSumOfPositiveElements(array);
GetSumOfNegativeElements(array);