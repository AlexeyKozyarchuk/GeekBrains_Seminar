/* 7. Напишите программу, которая принимает на вход
      трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8      */

void GetLastDigitOfNumber()
{
    System.Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    int length = number.Length;
    char result = number[length - 1];
    System.Console.WriteLine($"{number} -> {result}");
}

GetLastDigitOfNumber();