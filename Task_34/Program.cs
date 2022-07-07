// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using System;
using static System.Console;

Clear();
WriteLine("Введите размер массива: ");
int[] array = GetRandomArray(int.Parse(ReadLine()), 100, 999);

Write($"[{String.Join(", ", array)}]");

Write($" -> {CuantityPositiveNumbers(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i< size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}


int CuantityPositiveNumbers(int[] newArray)
{
    int count = 0;
    for(int i =0; i< newArray.Length; i++)
    {
        if(newArray[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}


