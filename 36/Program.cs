/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int SumNeg(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        count += array[i];
    }
    return count;
}

Console.Clear();
int[] arr = GetRandomArray(10, -20, 20);
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine($"Negative sum = {SumNeg(arr)}");

