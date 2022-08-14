/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число: ");
int randomNumber = Convert.ToInt32(Console.ReadLine());

int temp = randomNumber;
int rev = 0;

if (randomNumber > 2)
{
    while (randomNumber > 0)
    {
    int dig = randomNumber % 10;
    rev = rev * 10 + dig;
    randomNumber = randomNumber / 10;
    }
    if (temp == rev)
    {
    Console.WriteLine("Это палиндром!");
    }
    else
    {
    Console.WriteLine("Это не палиндром!");
    }
}


