/* Задача 22: Напишите программу, которая принимает на вход число (N)
              и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25
2 -> 1, 4                   */


void getNumbersSquare()
{
    System.Console.WriteLine("Здравствуйте, эта программа покажет"
            +   " Вам числа в квадрате от 1 до введённого Вами числа,"
            +   "\nВведите, пожалуйста, число: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    for (int i = 1; i <= number; i++)
    {
        double result = Math.Pow(i, 2);
        if (i == number)
        {
            System.Console.Write(result);
            break;
        }
        System.Console.Write($"{result}, ");
    }
}

getNumbersSquare();