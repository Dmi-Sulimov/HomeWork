// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

void NumArray(int[] array)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i] > 9 && arr[i] < 100)
        {  
            numExist++;
        }
    }
    if (numExist > 0)
       {
           Console.WriteLine($"Количество чисел: {numExist}");
       }
       else
       {
           Console.WriteLine("Чисел нет");
       }
}

GetArray(arr);
NumArray(arr);
