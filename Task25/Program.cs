// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Exponentiation(int digits, int degree)
{
    int count = 1;
    for (int i = 1; i <= degree; i++)
    {
        count *= digits;
    }
    return count;
}

bool ValidateDegree(int degree)
{
    if (degree < 0)
    {
        Console.Write("число B должно быть положительным, исправьте");
        return false;
    }
    return true;
}

Console.Write(" Введите число A -> ");
int a = int.Parse(Console.ReadLine());
Console.Write(" Введите число B -> ");
int b = int.Parse(Console.ReadLine());
if (ValidateDegree(b))
{
    Console.WriteLine($"A в степени B -> {Exponentiation(a, b)}");
}