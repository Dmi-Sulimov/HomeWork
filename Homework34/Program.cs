// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arr = new int [13];

void GetArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetEvenNumber(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    Console.WriteLine($"Четных чисел в массиве - {evenNum}");
}

GetArray(arr);
GetEvenNumber(arr);