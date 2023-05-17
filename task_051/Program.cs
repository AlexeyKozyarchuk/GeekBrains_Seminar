/*      Задача 51. Задайте двумерный массив. Найдите сумму элементов,
        находящихся на главной диагонали (с индексами (0, 0); (1, 1) и т.д.)

Например, задан массив:

1   4   7   2

5   9   2   3

8   4   2   4

Сумма элементов главной диагонали: 1 + 9 + 2 = 12       */

int SetNumber()
{
    int number = Int32.Parse(Console.ReadLine());
    return number;
}

void PrintNumber(int number1, int number2)
{
    System.Console.WriteLine($"\nm = {number1}, n = {number2}");
}

void PrintArray(int[,] collection)
{
    System.Console.WriteLine();
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            System.Console.Write($"{collection[i, j]}   ");
        }
        System.Console.WriteLine("\n");
    }
}

int[,] FillArray(int number1, int number2)
{
    int[,] array = new int[number1, number2];
    Random rnd = new Random();

    for (int i = 0; i < number1; i++)
    {
        for (int j = 0; j < number2; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

int[] GetOfArrayElementsMainDiagonal(int[,] collection)
{
    int[] sumArray = new int[collection.GetLength(1)];

    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (i == j) sumArray[i] = collection[i, j];
        }
    }
    return sumArray;
}

void PrintSumOfArray(int[] collection)
{
    int sumArray = 0;
    int length = collection.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            sumArray += collection[i];
            System.Console.Write($" {collection[i]}");
            break;
        }
        sumArray += collection[i];
        System.Console.Write($" {collection[i]} +");
    }
    System.Console.Write($" = {sumArray}");
}

System.Console.Write("Введите, пожалуйста, количество строк в Вашем массиве: ");
int numberFirst = SetNumber();
System.Console.Write("Введите, пожалуйста, количество столбцов в Вашем массиве: ");
int numberSecond = SetNumber();
PrintNumber(numberFirst, numberSecond);
int[,] array = FillArray(numberFirst, numberSecond);
PrintArray(array);
int[] sumArray = GetOfArrayElementsMainDiagonal(array);
System.Console.Write("Сумма элементов главной диагонали: ");
PrintSumOfArray(sumArray);
