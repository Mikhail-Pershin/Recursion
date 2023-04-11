// // Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// // Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// if (N <= 0)
// {
//   Console.Write($"{N} не натуральное число");
//   return;
// }

// string GetNaturalNumbers(int number)
// {
//   if (number == 1) return number.ToString();

//   return number + ", " + GetNaturalNumbers(number - 1);
// }

// Console.Write($"Натуральные числа в промежутке от N до 1 -> ");
// Console.Write(GetNaturalNumbers(number: N));



// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
if (M <= 0)
{
  Console.Write($"{M} не натуральное число");
  return;
}
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);
if (N <= 0)
{
  Console.Write($"{N} не натуральное число");
  return;
}

int NaturalNumbersSum(int start, int end, int total)
{
  if (start > end) return total;
  else
  {
    total += start;
    return NaturalNumbersSum(start + 1, end, total);
  }
}
int total = NaturalNumbersSum(start: M, end: N, total: 0);
Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N} -> {total}");
