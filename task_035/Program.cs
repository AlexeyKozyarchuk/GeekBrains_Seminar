/*          Задача 35: Задайте одномерный массив из 10 случайных чисел.
            Найдите количество элементов массива, значения которых лежат в
            отрезке [10,99]. 

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5        */

int[] FillArray()
{
    int[] array = new int[10];
    int length = array.Length;
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 200);
    }
    return array;
}

void FindNumberOfElements(int[] collection)
{
    int length = collection.Length;
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if ((collection[i] >= 10) && (collection[i] <= 99)) count++;
    }
    System.Console.Write(count);
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

int[] array = FillArray();
PrintArray(array);
System.Console.Write(" -> ");
FindNumberOfElements(array);