/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine());
int[] InitialArray = GetArray(length, 100, 1000);
Console.WriteLine($"[{String.Join(", ", InitialArray)}]");
Console.WriteLine($"Количество четных элементов - {CountEvenNumbers(InitialArray)}");


int[] GetArray(int size, int minValye, int maxValye)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValye, maxValye + 1);
    }
    return res;
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0) count++;
    }
    return count;
}