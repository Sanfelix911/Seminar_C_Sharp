﻿/*Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

//Метод вычисления функции Аккермана

int AkkermanFunction(int n, int m)
{


    {
        if (n == 0)
        {
            return m + 1;
        }
        else
        {
            if (m == 0)
            {
                return AkkermanFunction(n - 1, 1);
            }
        }
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
    }
}
Console.WriteLine("Введите два неотрицательных числа");
Console.Write("Первое число : ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число : ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат вычисления функции Аккермана с переменными {numb1} и {numb2} равен : ");
Console.WriteLine(AkkermanFunction(numb1, numb2));
