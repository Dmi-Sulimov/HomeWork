/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int randomNumber;

Console.WriteLine("Введите число: ");
randomNumber = Convert.ToInt32(Console.ReadLine());

if (randomNumber > 99)
{
    while (randomNumber > 999)
    {
        randomNumber = randomNumber / 10;
    }
    Console.WriteLine(randomNumber % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}