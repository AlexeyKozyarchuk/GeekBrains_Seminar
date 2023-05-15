/*      Задача 28: Напишите программу, которая
        принимает на вход число N и выдаёт
        произведение чисел от 1 до N.

4 -> 24
5 -> 120     */

void GetProductOfNumbers()
{
    System.Console.WriteLine("\nВведите, пожалуйста, число: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    int composition = 1;

    for (int i = 1; i <= number; i++)
    {
        composition *= i;
    }
    System.Console.WriteLine($"{number} -> {composition}");
}

GetProductOfNumbers();