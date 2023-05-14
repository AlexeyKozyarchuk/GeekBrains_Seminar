/* 9. Напишите программу, которая выводит случайное число
      из отрезка [10, 99] и показывает наибольшую цифру числа.

78 -> 8
12 -> 2
85 -> 8       */

void GetRandomValueFromSegment()
{
    string number = Convert.ToString(new Random().Next(10, 99));
    char max = number[0];
    if (number[1] > number[0]) max = number[1];
    System.Console.WriteLine($"{number} -> {max}");
}

GetRandomValueFromSegment();