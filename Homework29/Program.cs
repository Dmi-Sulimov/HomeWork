﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = {0, 0, 0, 0, 0, 0, 0, 0};

void Massive()
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write($"{array[i]} ");
    }
}
Massive();