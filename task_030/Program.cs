/*      Задача 30: Напишите программу, которая
        выводит массив из 8 элементов, заполненный
        нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]      */

int[] FillArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i == length - 1)
        {
            System.Console.Write($"{array[i]}]");
            break;
        }
        System.Console.Write($"{array[i]},");
    }
}

int[] array = FillArray();
PrintArray(array);