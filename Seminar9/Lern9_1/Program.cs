/*Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShovNumb(int n){
    if(n>1) ShovNumb(n-1);
    Console.Write(n+" ");
}
ShovNumb(5);*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 8; N = 4 -> "4, 6, 7, 8"

// void ShowNumRange(int n, int m){
//     if (n != m) ShowNumRange(Math.Min(n,m), Math.Max(n,m)-1);
//     Console.Write($"{Math.Max(n,m)} ");
// }

// ShowNumRange(10,20);

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// -45 -> 9

// int SumDigits(int n){
//     if (n<0) n *= (-1);
//     if (n==0) return 0;
//     return SumDigits(n/10) + n % 10;     
// }

// Console.WriteLine("Enter num:");
// int n = Convert.ToInt32(Console.ReadLine());
// int summ = SumDigits(Convert.ToInt32(Console.ReadLine()));
// Console.Write($"Your sum is {summ}");

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

// 2^(-1) = 1/2 = 0.5
// 2^(-3) = 1/(2^3) = 1/8 = 0.125
// -2^0 = 1
// 1/2*2*2 = 1/8 = 0,125

// double FindPow(int a, int b){
//     if(b == 0) return 1.0;
//     if(b > 0) return FindPow(a,b-1) * a;
//     return FindPow(a, b+1) / a;
// }

// double res = FindPow(5, 4);
// Console.WriteLine(res);


