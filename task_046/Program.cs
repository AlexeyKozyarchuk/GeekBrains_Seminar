/*          Задание 46: Задайте двумерный массив размером m*n,
            заполненный случайными целыми числами.

m = 3, n = 4.
1    4     8     19

5   -2     33    -2

77   3     8      1         */

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
