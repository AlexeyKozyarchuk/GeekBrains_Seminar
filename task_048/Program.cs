/*          Задание 46: Задайте двумерный массив размером m*n,
            каждый элемент в массиве находится по формуле A = m + n.
            Выведите полученный массив на экран.

m = 3, n = 4.

0   1   2   3

1   2   3   4

2   3   4   5        */

int[,] FillArray(int number1, int number2)
{
    int[,] array = new int[number1, number2];
    Random rnd = new Random();
    int count = 0;
    int count2 = 1;

    for (int i = 0; i < number1; i++)
    {
        for (int j = 0; j < number2; j++)
        {
            array[i, j] += count;
            count++;
        }
        count = count2;
        count2++;
    }
    return array;
}

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

System.Console.Write("Введите, пожалуйста, количество строк в Вашем массиве: ");
int numberFirst = SetNumber();
System.Console.Write("Введите, пожалуйста, количество столбцов в Вашем массиве: ");
int numberSecond = SetNumber();
PrintNumber(numberFirst, numberSecond);
int[,] array = FillArray(numberFirst, numberSecond);
PrintArray(array);
