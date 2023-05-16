/*          Задача 42: Напишите программу, которая будет преобразовывать
            десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10           */

int SetNumber()
{
    System.Console.Write("Введите пожалуйста число: ");
    int number = Int32.Parse(Console.ReadLine());
    return number;
}


void PrintNumber(int number)
{
    System.Console.Write(number);
}


void PrintReversalOfString(string collection)
{
    int length = collection.Length;
    string stringReversal = String.Empty;

    for (int i = length - 1; i >= 0; i--)
    {
        stringReversal += collection[i];
    }
    System.Console.Write(stringReversal);
}


string GetConvertibleNumbers(int number)
{
    string numberConverted = string.Empty;

    if (number == 0) 
    {
        numberConverted = "0";
    }
    else
    {
        while(number != 1)
        {
            if (number % 2 == 0) numberConverted += "0";
            else numberConverted += "1";
            number /= 2;
        }
        numberConverted += 1;
    }
    return numberConverted;
}

int number = SetNumber();
PrintNumber(number);
System.Console.Write(" -> ");
string stringNumber = GetConvertibleNumbers(number);
PrintReversalOfString(stringNumber);
