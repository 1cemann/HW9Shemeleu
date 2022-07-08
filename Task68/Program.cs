// Задача 68: Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using System;
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = Convert.ToInt32(ReadLine());
WriteLine("Введите N: ");
int N = Convert.ToInt32(ReadLine());
Write(Ack(M,N));


int Ack(int n, int m)
{
    return n == 0 ? m + 1 : Ack(n - 1, m == 0 ? 1 : Ack(n, m - 1));
}


// Наверное в условии неправильно заданы переменные, если М и Н поменять местами то тогда ответ будет 29, а так получается 9!!!!!!))