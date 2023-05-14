/* 12. Напишите программу, которая будет принимать на вход два числа
       и выводит, является ли второе число кратным первому.
       Если число 2 не кратно числу 1, то программа выводит остаток от деления

34, 5 -> не кратно, остаток 4
16, 4 -> кратно                     */

int SetNumber()
{
    System.Console.WriteLine("Введите пожалуйста число: ");
    int number = Int32.Parse(Console.ReadLine());
    return number; 
}

void SecondNumberIsMultipleFirst(int number1, int number2)
{
    System.Console.Write($"{number1}, {number2} -> ");
    int result = number1 % number2;
    if (result == 0) System.Console.Write("кратно");
    else System.Console.Write($"не кратно, остаток {result}");
}

int firstNumber = SetNumber();
int secondNumber = SetNumber();
SecondNumberIsMultipleFirst(firstNumber, secondNumber);
