// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string c = "";

string TenToTwo(int number, string s)
{
    s = number % 2 + s;
    if (number > 1) s = TenToTwo(number /= 2, s);
    return s;
}

c = TenToTwo(a,c);
Console.Write(c);