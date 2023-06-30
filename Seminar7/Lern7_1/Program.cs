/*Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

int [,] Create2DArray () // создание двумерного массива
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collumns: ");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    int [,] created2dArray = new int [userRows,userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColls; j++)
        {
            created2dArray[i,j] = new Random().Next(userMin, userMax + 1);
        }
    }
    return created2dArray;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();//переход вывода на новую строку
    }
    Console.WriteLine();// отступ от массива
}

int [,] new2dArray = Create2DArray();
Print2DArray(new2dArray);*/

/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
1 2 3 4      [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/
/*Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
/и замените эти элементы на их квадраты.*/