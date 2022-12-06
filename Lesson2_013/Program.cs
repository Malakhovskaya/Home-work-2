/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет*/

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс числа от 1 и далее: ");
int index = Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow(10, index);
Console.Clear();

if (num < pow)
{
    Console.WriteLine($"Такой цифры нет");
    return;
}

int tmp = num;

while (tmp > pow)
{
    tmp /= 10;
}
int result = tmp % 10;
Console.WriteLine($"Цифра под индексом {index} числа {num}: {result}");

