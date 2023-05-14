/* 3. Напишите программу, которая будет выдавать
      название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница    */

System.Console.WriteLine("Введите, пожалуйста, день недели: ");
string dayOfWeek = Console.ReadLine();
System.Console.Write("\n" + dayOfWeek + " ");
switch (dayOfWeek)
{
    case "1":
        System.Console.Write("-> Понедельник");
        break;
    case "2":
        System.Console.Write("-> Вторник");
        break;
    case "3":
        System.Console.Write("-> Среда");
        break;
    case "4":
        System.Console.Write("-> Четверг");
        break;
    case "5":
        System.Console.Write("-> Пятница");
        break;
    case "6":
        System.Console.Write("-> Суббота");
        break;
    case "7":
        System.Console.Write("-> Воскресенье");
        break;
}

		
		