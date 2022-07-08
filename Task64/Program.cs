//Задайте значения M и N. Напишите программу, которая выведет произведение 
//натуральных чисел в промежутке от M до N.

//M = 1; N = 5. ->120

//M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = Convert.ToInt32(ReadLine());
WriteLine("Введите N: ");
int N = Convert.ToInt32(ReadLine());
Write(Multiple(M,N));

double Multiple(double a, double b)
{
    return (a < b) ? a * Multiple(a + 1, b) : a;
}