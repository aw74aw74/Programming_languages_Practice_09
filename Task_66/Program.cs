/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;

Write("Введите число начала промежутка: ");
int numberBegin = int.Parse(ReadLine()!);
Write("Введите число окончания промежутка: ");
int numberEnd = int.Parse(ReadLine()!);
WriteLine(GetSumN(numberBegin, numberEnd));

int GetSumN(int m, int n)
{
  if (m <= n)
  {
    return m + GetSumN(m + 1, n);
  }
  else return 0;
}