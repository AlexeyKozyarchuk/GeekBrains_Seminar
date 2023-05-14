/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
       причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости в которой находится эта точка.

*/

double[] SetNumberForPoint()
{
    System.Console.WriteLine("Введите, пожалуйста, значение точки X(кроме 0): ");
    double numberX = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите, пожалуйста, значение точки Y(кроме 0): ");
    double numberY = double.Parse(Console.ReadLine());
    double[] numberCoordinate = new double[2]{numberX, numberY};
    return numberCoordinate;
}

void GetValuePlaneCoordinates(double[] pointXAndY)
{
    string placePoint = "Точка находится в четверти под номером: ";
    if ((pointXAndY[0] > 0) && (pointXAndY[1] > 0)) System.Console.WriteLine(placePoint + "1");
    else if ((pointXAndY[0] < 0) && (pointXAndY[1] > 0)) System.Console.WriteLine(placePoint + "2");
    else if ((pointXAndY[0] < 0) && (pointXAndY[1] < 0)) System.Console.WriteLine(placePoint + "3");
    else if ((pointXAndY[0] > 0) && (pointXAndY[1] < 0)) System.Console.WriteLine(placePoint + "4");
    else System.Console.WriteLine("Вы ввели недопустимые значение!");
}

double[] pointXAndY = SetNumberForPoint();
GetValuePlaneCoordinates(pointXAndY);