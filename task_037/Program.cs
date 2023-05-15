/*      Задача 37: Найдите произведение пар чисел в одномерном массиве.
        Парой считаем первый и последний элемент, второй и предпоследний
        и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21           */

int[] FillArray()
{
    Random rnd = new Random();
    int size = rnd.Next(3, 10);
    int[] array = new int[size];
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 20);
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

void ProductOfExtremeDigits(int[] collection)
{
    int length = collection.Length;
    int lengthHalf = 0;
    int countStart = -1;
    int countEnd = length;
    if (length % 2 == 0) lengthHalf = length / 2;
    else lengthHalf = length / 2 + 1;
    int[] collectionСomposition = new int[lengthHalf];

    for (int i = 0; i < lengthHalf; i ++)
    {
        if (collection[countStart + 1] == collection[countEnd - 1]) 
        {
            System.Console.Write(collection[i]);
            break;
        }
        collection[i] = collection[countStart + 1] * collection[countEnd - 1];
    if (i == lengthHalf - 1)
    {
            System.Console.Write($" {collection[i]}");
            break;
    }
        System.Console.Write($"{collection[i]}, ");
        countStart++; countEnd--;
    }
}

int[] array = FillArray();
PrintArray(array);
System.Console.Write(" -> ");
ProductOfExtremeDigits(array);