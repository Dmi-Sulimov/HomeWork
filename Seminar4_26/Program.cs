// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int HowMuchIsTheDigits(int number)
{
    int digitCounter = 0;
    while (number!=0)
    {
        number = number/10;
        digitCounter++;
    }
    return digitCounter;
}

Console.WriteLine($"Количество цифр в числе {number} = {HowMuchIsTheDigits(number)}");