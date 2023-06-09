Console.WriteLine("Введите трехзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb > 99 && numb < 1000)
{
    Console.Write(numb % 10);
}
else
{
    Console.Write("Вы ввели не трёхзначное число");
}