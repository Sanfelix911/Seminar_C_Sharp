//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/*int[] CreateNewArray(int size, int minV, int maxV)
{
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = new Random().Next(minV, maxV + 1);
    }
    return arrayNew;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] arrayToRevers)
{
    int k = arrayToRevers.Length;
    for (int i = 0; i < k / 2; i++)
    {
        int temp = arrayToRevers[i];
        arrayToRevers[i] = arrayToRevers[k - 1 - i];
        arrayToRevers[k - 1 - i] = temp;
    }
    return arrayToRevers;
}

int size_array = 7;
int min_val_array = -9;
int max_val_array = 9;
int[] createdArray = CreateNewArray(size_array, min_val_array, max_val_array);
ShowArray(createdArray);
int[] reversedArray = ReversArray(createdArray);
ShowArray(reversedArray);*/

//Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
//45 -> 101101
//3  -> 11

/*int CountOfBinar (int user_num)
{
    int countOfDigits = 0;
    while (user_num != 0)
    {
        user_num = user_num / 2;
        countOfDigits++;
    }
    return countOfDigits;
}

int [] ConversionToBinar (int numToConvert)
{
    int n = CountOfBinar(numToConvert);
    int [] binarNum = new int [n];

    for (int i = n - 1; i >= 0; i--)
    {
        binarNum[i] = numToConvert % 2;
        numToConvert /= 2;
    }
    return binarNum;
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
Console.WriteLine();
}

int userNumber = 75;
int countOfElem = CountOfBinar(userNumber);
int [] binar = ConversionToBinar(userNumber);
ShowArray(binar);*/
//Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: a и b (пользователь).

/*void Fibonacci (int n, int a, int b)
{
    int [] arrFibonacci = new int [n];
    arrFibonacci[0] = a;
    arrFibonacci[1] = b;
    for (int i = 2; i < n; i++)
    {
        arrFibonacci[i] = arrFibonacci[i-2] + arrFibonacci[i-1];
    }
    ShowArray(arrFibonacci);
}

void ShowArray (int [] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i != arrayToShow.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
Console.WriteLine();
}

Console.WriteLine("Enter count of elements: ");
int userCount = Convert.ToInt32(Console.ReadLine());

if (userCount > 2)
{
    Console.WriteLine("Enter first element: ");
    int userFirstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second element: ");
    int userSecondNum = Convert.ToInt32(Console.ReadLine());

    Fibonacci(userCount, userFirstNum, userSecondNum);
}
else
{
    Console.WriteLine("Impossible value!");
}*/
//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.

/*void Triangle(int firstSide, int secondSide, int thirdSide)
{
    int [] sides = {firstSide, secondSide, thirdSide};
    if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[1] + sides[0])
    {
        Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} exists!");
    }
    else
    {
        Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} does NOT exist!");
    }
}

Triangle(3,4,5);*/

