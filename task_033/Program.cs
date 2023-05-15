/*      Задача 33: Задайте массив. Напишите программу, которая
        определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да     */

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

void IsNumberInArray(int[] collection)
{
    System.Console.WriteLine("Введите, пожалуйста, число: ");
    int number = Int32.Parse(Console.ReadLine());
    int length = collection.Length;

    for (int i = 0; i < length; i++)
    {
        if (collection[i] == number) 
        {
            System.Console.Write($"{number}; массив");
            PrintArray(collection);
            System.Console.Write(" -> да");
            break;
        }
        if (i == length - 1)
        {
            System.Console.Write($"{number}; массив");
            PrintArray(collection);
            System.Console.Write(" -> нет");
            break;
        }
    }
}

int[] array = FillArray();
PrintArray(array);
System.Console.WriteLine();
IsNumberInArray(array);
