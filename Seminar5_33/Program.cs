// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = new int [20];

void GetArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        int value = rnd.Next(100);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void NumArray(int[] array, int num)
{
    int numExist = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i] == num)
        {  
            numExist++;
        }
    }
    if (numExist > 0)
       {
           Console.WriteLine("Число есть");
       }
       else
       {
           Console.WriteLine("Числа нет");
       }
}

GetArray(arr);
NumArray(arr, num);