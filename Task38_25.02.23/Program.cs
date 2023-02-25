/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
Console.Write("Введите размер массива - ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите начальное значение для диапазона случайного числа - ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение для диапазона случайного числа - ");
int end = int.Parse(Console.ReadLine());
double[] Array = Zapolnenie(length, start, end);
Console.WriteLine($"[{String.Join(";  ", Array)}]");
Console.Write($"Разница между максимальным и минимальным элементами массива = {Deduct(Array)}");

double[] Zapolnenie(int size, int min, int max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

double Deduct(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    foreach (double el in array)
    {
        if (el > max) max = el;
        if (el < min) min = el;
    }
    Console.WriteLine($"max -> {max} , min -> {min}");
    result += max - min;
    return result;
}