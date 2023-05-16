/*          Задача 39: Напишите программу, которая перевернёт
            одномерный массив (последний элемент будет на первом
            месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]          */

int[] FillArray()
{
    Random rnd = new Random();
    int size = rnd.Next(3, 10);
    int[] array = new int[size];
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 10);
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

void PrintReversalOfArray(int[] collection)
{
    int length = collection.Length;
    int[] arrayReversal = new int[length];
    int countStart = -1;
    int countEnd = length;

    System.Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        arrayReversal[i] = collection[countEnd - 1];
        if (i == length - 1)
        {
            System.Console.Write($"{arrayReversal[i]}]");
            break;
        }
        System.Console.Write($"{arrayReversal[i]},");
        countEnd--;
    }
}

int[] array = FillArray();
PrintArray(array);
System.Console.Write(" -> ");
PrintReversalOfArray(array);