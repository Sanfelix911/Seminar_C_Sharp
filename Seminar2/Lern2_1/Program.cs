int Line()
{
    int number = new Random().Next(10, 100);
    Console.WriteLine("Your num is - " + number);
    int dec = number / 10;
    int ed = number % 10;
    if (dec > ed)
    {
        return dec;
    }
    else
    {
        return ed;
    }
}

Console.WriteLine("Result is - " + Line());