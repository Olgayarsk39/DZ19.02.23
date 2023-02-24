// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] Zapolnenie(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите начальное значение для диапазона случайного числа - ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение для диапазона случайного числа - ");
int end = int.Parse(Console.ReadLine());
int[] array = Zapolnenie(length, start, end);
Console.Write($"[{String.Join(";  ", array)}]");
