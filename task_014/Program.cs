/* 14. Напишите программу, которая принимает на вход число
       и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да         */

int SetNumber()
{
    System.Console.WriteLine("Введите пожалуйста число: ");
    int number = Int32.Parse(Console.ReadLine());
    return number; 
}

void IsNumber7And23Multiple(int number)
{
    System.Console.Write($"{number} -> ");
    if ((number % 7 == 0) && (number % 23 == 0)) System.Console.Write("да");
    else System.Console.Write("нет");
}

int number = SetNumber();
IsNumber7And23Multiple(number);