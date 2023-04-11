// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
if (N <= 0)
{
  Console.Write($"{N} не натуральное число");
  return;
}

string GetNaturalNumbers(int number)
{
  if (number == 1) return number.ToString();

  return number + ", " + GetNaturalNumbers(number - 1);
}

Console.Write($"Натуральные числа в промежутке от N до 1 -> ");
Console.Write(GetNaturalNumbers(number: N));