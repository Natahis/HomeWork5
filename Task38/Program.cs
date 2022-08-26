// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] array = {2.3, 3.5, 7.1, 22.9, 78.5};

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i]} ");
        else if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}]");
    }
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        diff = max - min;
    }
    return diff;
}

PrintArray(array);
double result = DiffMaxMin(array);
Console.Write($" -> {result}");
