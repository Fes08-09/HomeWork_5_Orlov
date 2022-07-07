// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


using System;
using static System.Console;

Clear();
WriteLine("Введите размер массива: ");
int[] array = GetRandomArray(int.Parse(ReadLine()), 0, 10);
Write($"[{String.Join(", ", array)}]");

Write($" -> {SumElemInOddPosition(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i< size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}


int SumElemInOddPosition(int[] newArray)
{
    int sum = 0;
    for(int i =0; i< newArray.Length; i++)
    {
        if((i %2) ! == 0) 
        {
            sum+=newArray[i];
        }
    }
    return sum;
}

