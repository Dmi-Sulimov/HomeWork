/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a;
int b;
int c;
int max;

Console.WriteLine("Введите число 1: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;
if (b > a)
{
    max = b;
}
if (c > b)
{
    max = c;
}

Console.WriteLine("Максимальное число = " + max);