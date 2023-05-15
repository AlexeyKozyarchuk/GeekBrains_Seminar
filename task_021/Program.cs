/* Задача 21:   Напишите программу, которая принимает на вход координаты двух точек
                и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1), -> 5.09
A (7,-5); B (1,-1) -> 7.21       */

 void getDistance2DSpaces()
{
    System.Console.WriteLine("Здравствуйте, эта программа расчитает"
            +   " Вам расстояние в 2D пространстве между двумя точками,"
            +   " Вам нужно задать 2 координаты каждой точке.\n"
            +   "Введите, пожалуйста, координаты точки А(пример: 34, где 3 -> x, 4 -> y): ");
    string numberA = Console.ReadLine();

    System.Console.WriteLine("Введите, пожалуйста, координаты точки B(пример: 57, где 5 -> x, 7 -> y): ");
    string numberB = Console.ReadLine();

    double resultIntermediate = ((numberB[0] - numberA[0]) * (numberB[0] - numberA[0])) 
                  + ((numberB[1] - numberA[1]) * (numberB[1] - numberA[1]));
    double resultEnd = Math.Round(Math.Pow(resultIntermediate, 0.5), 2);
    
    System.Console.WriteLine($"\nA ({numberA[0]},{numberA[1]}); " +
                             $"B ({numberB[0]},{numberB[1]}), -> {resultEnd}");
}

getDistance2DSpaces();