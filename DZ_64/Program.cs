//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Gрограмма, которая выведет все натуральные числа в промежутке от N до 1.");
Console.ForegroundColor = ConsoleColor.Blue;
int number = InputNumber("Введите N: ");
int count = 2;
Console.ForegroundColor = ConsoleColor.DarkYellow;
PrintNumber(number, count);
Console.Write(1);

void PrintNumber(int num, int count)
{
  if (count > num) return;
  PrintNumber(num, count + 1);
  Console.Write(count + ", ");
}

int InputNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}