//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Программу вычисления функции Аккермана с помощью рекурсии");


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте значение M = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Задайте значение N = ",""); 
int n = int.Parse(Console.ReadLine() ?? "0");


int FunctionAkkerman = akkerman(m, n);
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"Функция Аккермана = {FunctionAkkerman} ");

int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}