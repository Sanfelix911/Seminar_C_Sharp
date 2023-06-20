//Принимает число А и выдает сумму от 1 до А

void Sum1ToA(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Sum1ToA(10);