// Задача 64: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Задайте количество строк матрицы M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество строк матрицы N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(n, m));
int Number(int n, int m)
{
    int max = m;
    int min = n;
    if (max < min)
    {
        max = n;
        min = m;
    }
    if (min == max)
        return min;
    else
    {
        Console.Write(Number(max - 1, min) + ", ");
        return max;
    }
}