/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным */

Console.WriteLine("Введите день недели в числовом формате (1,2, ..., 7) : ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
switch (dayWeek)
{
    case 1:
        Console.WriteLine("Понедельник- Не является выходным");
        break;
    case 2:
        Console.WriteLine("Вторник- Не является выходным");
        break;
    case 3:
        Console.WriteLine("Среда- Не является выходным");
        break;
    case 4:
        Console.WriteLine("Четверг- Не является выходным");
        break;
    case 5:
        Console.WriteLine("Пятница- Не является выходным");
        break;
    case 6:
        Console.WriteLine("Суббота в России является выходным днем");
        break;
    case 7:
        Console.WriteLine("Воскресенье в России является выходным днем");
        break;
    default:
        Console.WriteLine("Некорректный номер дня недели");
        break;
}

