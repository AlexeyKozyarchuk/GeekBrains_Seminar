/*          Задача 32: Напишите программу замены элементов
            массива: положительные элементы замените на
            соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]         */

int[] FillArray()
{
    int size = 4;
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

int[] ConverterArray(int[] collection)
{
    int length = collection.Length;
    int[] converterArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        converterArray[i] = collection[i] * -1;
    }
    return converterArray;
}

int[] array = FillArray();
PrintArray(array);
System.Console.Write(" -> ");
int[] arrayConverter = ConverterArray(array);
PrintArray(arrayConverter);