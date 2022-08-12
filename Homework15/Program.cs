/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

int dayOfWeek;

Console.WriteLine("Введите день недели от 1 до 7: ");
dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 0 && dayOfWeek < 8)
{
    if (dayOfWeek > 5 && dayOfWeek < 8)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7!: ");
    dayOfWeek = Convert.ToInt32(Console.ReadLine());
    if (dayOfWeek > 0 && dayOfWeek < 8)
    {
        if (dayOfWeek > 5 && dayOfWeek < 8)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}
