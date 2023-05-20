/* 11. Напишите программу, которая выводит случайное
       трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98     */


void GetRandomValueFromSegment()
{
    string numberEntered = Convert.ToString(new Random().Next(100, 999));
    System.Console.WriteLine($"{numberEntered} -> {numberEntered[0]}{numberEntered[2]}");
}

GetRandomValueFromSegment();