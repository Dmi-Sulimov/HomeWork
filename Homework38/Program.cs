// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] arr = new int [8];

void GetArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(-100, 100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetDiffMaxMin(int[] array)
{
    int minNumber = arr[0];
    int maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minNumber > arr[i]) minNumber = arr[i];
        if (maxNumber < arr[i]) maxNumber = arr[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом равны: {maxNumber - minNumber}");
}

GetArray(arr);
GetDiffMaxMin(arr);