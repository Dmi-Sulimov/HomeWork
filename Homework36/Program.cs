// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

GetArray(arr);

void GetSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом равна: {sum}");
}

GetSum(arr);