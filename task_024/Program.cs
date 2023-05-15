/* Задача 22: Напишите программу, которая принимает на вход число (A)
              и выдаёт сумму чисел от 1 до A.

7 -> 28
4 -> 10
8 -> 36                   */

void getNumbersSum()
{
    System.Console.WriteLine("\nВведите, пожалуйста, число: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    System.Console.WriteLine($"{number} -> {sum}");
}

getNumbersSum();