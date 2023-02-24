// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int Sum(int n)
{
    int result = 0;
    while (n > 0)
    {
        result += n%10;
        n /= 10;
    }
    return result;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Write(Sum(N));