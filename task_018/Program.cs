/* Задача 18: Напишите программу, которая по заданному номеру четверти,
              показывает диапозон возмонжых координат точек в этой четверти (x и y).

*/

void GetNumberQuarter()
{
    System.Console.WriteLine("Введите номер четверти: ");
    string numberQuarter = Console.ReadLine();
    string rangeXAndY = "Диапозон возможных координат точне в этой четверти равен: ";
    switch (numberQuarter)
    {
        case "1":
            System.Console.WriteLine($"{rangeXAndY}(x = +бесконечность, y = +бесконечность)");
            break;
        case "2":
            System.Console.WriteLine($"{rangeXAndY}(x = -бесконечность, y = +бесконечность)");
            break;
        case "3":
            System.Console.WriteLine($"{rangeXAndY}(x = -бесконечность, y = -бесконечность)");
            break;    
        case "4":
            System.Console.WriteLine($"{rangeXAndY}(x = +бесконечность, y = -бесконечность)");
            break;
        default:
            System.Console.WriteLine("Вы ввели неправильное значение!");
            break;     
    }
}

GetNumberQuarter();