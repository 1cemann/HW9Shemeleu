//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = Convert.ToInt32(ReadLine());
WriteLine("Введите N: ");
int N = Convert.ToInt32(ReadLine());
Write(Summ(M,N));

double Summ(double a, double b)
{
    return (a < b) ? a + Summ(a + 1, b) : a;
}