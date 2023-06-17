/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
/*void PossibleValue (int quadro)
{
    if (quadro == 1)
        Console.WriteLine ("1st quater x > 0, y > 0");
    else if (quadro == 2)
        Console.WriteLine ("2nd quater x < 0, y > 0");
    else if (quadro == 3)
        Console.WriteLine ("3rd quater x < 0, y < 0");
    else 
        Console.WriteLine ("4st quater x > 0, y < 0");
}

Console.WriteLine("Input number of quater: ")     ;
int numQater = Convert.ToInt32(Console.ReadLine());

if(numQater >= 1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine("its not number of quater!");*/
/*//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int Diapason (int quadro)
{
    if (quadro == 1)
        return 1;
    else if (quadro == 2)
        return 2;
    else if (quadro == 3)
        return 3;
    else
        return 4;
}
System.Console.WriteLine("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (a <= 0 || a > 4) System.Console.WriteLine("Айяйяй");
else {
    result = Diapason(a);

if (result == 1)
{
    System.Console.WriteLine("Ваш диапазон x > 0 и y > 0");
}
else if (result == 2)
{
    System.Console.WriteLine("Ваш диапазон x < 0 и y > 0");
}
else if (result == 3)
{
    System.Console.WriteLine("Ваш диапазон x < 0 и y < 0");
}
else
{
    System.Console.WriteLine("Ваш диапазон x > 0 и y < 0");
}
}*/
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A(x1,y1); B(x2,y2)
/*double distanceAB(int xA, int yA, int xB, int yB)
{
    double distance = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA));
    distance = Math.Round(distance,2);
    return distance;
}
Console.WriteLine("Введите четверть: xA");
int xAcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четверть yA");
int yAcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четверть xB");
int xBcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четверть yB ");
int yBcor = Convert.ToInt32(Console.ReadLine());
//Math.Sqrt(25);
double dist = distanceAB(xAcor, yAcor, xBcor, yBcor);
Console.WriteLine(dist);*/
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.
void SqurePrinter(int numberN)
{
        int current = 1;
        while (current <= numberN)
        {
                double res = Math.Pow(current,2);
                Console.Write($"{res:f0}, ");
                current++;
        }
        Console.WriteLine("\b\b.");
}
void SqurePrinterNeg(int numberN)
{
        int current = 1;
        while (current >= numberN)
        {
                double res = Math.Pow(current,2);
                Console.Write($"{res:f0}, ");
                current--;
        }
        Console.WriteLine("\b\b.");
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
        SqurePrinter(user_number);
else
        SqurePrinterNeg(user_number);