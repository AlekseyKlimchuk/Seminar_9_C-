//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программу, которая найдёт сумму натуральных элементов в промежутке от M до N");


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте значение M = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте значение N = ",""); 
int n = int.Parse(Console.ReadLine() ?? "0");

int SumNum(int m, int n)
{
    if (m < n)
    {
        if (m == n)
        {
            return n;
        }
        return n + SumNum(m, n - 1);

    }
    else
    {
        if (m == n)
        {
            return n;
        }
        return n + SumNum(m, n + 1);

    }
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine(SumNum(m, n));