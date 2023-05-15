/*          Задача 26: Напишите программу, которая
            принимает на вход число и выдаёт количество цифр
            в числе.

456 -> 3
78 -> 2
89126 -> 5     */

void NumberDigitsInNumber()
{
    System.Console.WriteLine("Введите, пожалуйста, число: ");
    string number = Console.ReadLine();
    int length = number.Length;

//-------- Добавил функционал, если число будет отрицательное -----------
    char index = '-';
    int numberMinusOne = length - 1;
    if (number[0] == index) System.Console.WriteLine($"{number} -> {numberMinusOne}");
//-----------------------------------------------------------------------

    else System.Console.WriteLine($"{number} -> {length}");
}

NumberDigitsInNumber();