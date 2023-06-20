//Принимает число А и выдает сумму от 1 до А

/*void Sum1ToA(int a)
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
Sum1ToA(10);*/
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
int[] NewArray(int size_array)
{
    int[] random1Arrai = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {
        random1Arrai[i] = new Random().Next(0, 2);
    }
    return random1Arrai;
}
void PrintArray(int[] array)
{
    Console.Write("Ваш массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int size=8;
int[] array1 = NewArray(size);
PrintArray(array1);