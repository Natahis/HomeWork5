// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




int[] GreatArray(int min, int max)
{
    int size = new Random().Next(4, 9);
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]},");
        else if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}]");
    }
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] arr = GreatArray(-99, 100);
PrintArray(arr);
int result = Sum(arr);
Console.Write($" -> {result}");
