// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write($"Введи количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNews = new int[m];

void InputNumbers(int m)
{
    int i = 0;
    while (i < m)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNews[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
}

int Comparison(int[] massiveNews)
{
    int count = 0;
    for (int i = 0; i < massiveNews.Length; i++)
    {
        if (massiveNews[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел > 0: {Comparison(massiveNews)} ");