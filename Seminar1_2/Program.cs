Console.WriteLine("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if(numb1 == numb2 * numb2)
{
    Console.WriteLine("Первое чило является квадратом второго");
}
else
{
    Console.WriteLine("Первое чило не является квадратом второго"); 
}