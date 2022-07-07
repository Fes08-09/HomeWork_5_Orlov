// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using static System.Console;

Clear();
WriteLine("Задайте количество элементов массива: ");
int[] array = GetRandomArray(int.Parse(ReadLine()), 1, 100);
Write($"[{String.Join(" ", array)}]");
Write($" -> {DifferMaxMinElements(array)}");



int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int DifferMaxMinElements(int[] newArray)
{
    int difference = 0;
    int min = newArray[0];
    int max = newArray[0];
    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] < min)
        {
            min = newArray[i];
        }
        if (newArray[i] > max)
        {
            max = newArray[i];
        }
    }
    difference = max - min;
    return difference;
}

