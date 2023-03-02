﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-ый элемент -   ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"a[{i}] = {array[i]};   ");
    }
    Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int length = Prompt("Введите количество элементов - ");
int[] array;
array = InputArray(length);
PrintArray(array);
// Console.Write("Введите элементы через пробел - ");
// string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int [] array = int.Parse(st[1]);
// int B = int.Parse(st[1]);
// int C = int.Parse(st[2]);


Console.WriteLine($"Количество положительных чисел - {CountPositiveNumbers(array)}");