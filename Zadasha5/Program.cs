﻿Console.WriteLine("Введите число N");
string nfirst = Console.ReadLine() ??"";
int n = Convert.ToInt32(nfirst);
n = Math.Abs(n);
    for (int i = (-n); i <= n; i++)
{
    Console.Write(i + " ");
}
