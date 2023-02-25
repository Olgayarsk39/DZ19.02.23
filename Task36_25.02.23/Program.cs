/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите начальное значение для диапазона случайного числа - ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение для диапазона случайного числа - ");
int end = int.Parse(Console.ReadLine());
int[] Array = Zapolnenie(length, start, end);
Console.WriteLine($"[{String.Join(";  ", Array)}]");
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {Sum(Array)}");

int[] Zapolnenie(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int Sum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        result += array[i];
    }
    return result;
}
