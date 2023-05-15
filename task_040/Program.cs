/*          Задача 40: Напишите программу, которая принимает на вход три
            числа и проверяет, может ли существовать треугольник со
            сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон        */

int[] FillArray()
{
    int[] array = new int[3];
    int length = array.Length;

    for (int i = 1; i <= length; i++)
    {
        System.Console.WriteLine($"Введите, пожалуйста, длину {i} стороны: ");
        array[i - 1] = Int32.Parse(Console.ReadLine());
    }
    System.Console.WriteLine();
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

void IsTriangleTrue(int[] collection)
{
    if ((collection[0] < collection[1] + collection[2]) &&
        (collection[1] < collection[0] + collection[2]) &&
        (collection[2] < collection[0] + collection[1]) == true) System.Console.Write(" -> Треугольник существует");
    else System.Console.Write(" -> Треугольник не существует");
}

int[] array = FillArray();
PrintArray(array);
IsTriangleTrue(array);