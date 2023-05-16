/*          Задача 45: Напишите программу, которая будет создавать
            копию заданного массива с помощью поэлементного
            копирования. 

*/

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

int[] CopyArray(int[] collection)
{
    int length = collection.Length;
    int[] arrayCopy = new int[length];

    for (int i = 0; i < length; i++)
    {
        arrayCopy[i] = collection[i];
    }
    return arrayCopy;
}

int[] array = FillArray();
PrintArray(array);
System.Console.Write(" -> копия - ");
int[] arrayCopy = CopyArray(array);
PrintArray(arrayCopy);