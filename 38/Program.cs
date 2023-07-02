/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/


double[] GetRandomArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue + 1) + minValue;
    }

    return result;
}

void Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i]<min) min=array[i];
        if (array[i]>max) max=array[i];
    }
    Console.WriteLine($"Минимальное значение => {min:f1}");
    Console.WriteLine($"Максимальное значение => {max:f1}");
    Console.WriteLine($"Ответ => ({min:f1}) - ({max:f1}) = {max-min:f1}");
}

Console.Clear();
double[] arr = GetRandomArray(10, -20, 20);
Console.WriteLine(String.Join(", ", arr));
Difference(arr);