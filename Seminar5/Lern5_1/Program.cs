///Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*int[] CreateArray(int size, int minVal, int maxVal)

{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minVal, minVal - 1);
    }
    return newArray;
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i] + "");
    }
    Console.WriteLine();
}

void FindSumNegElem(int[] array)
{
    int sumNegElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegElem += array[i];
        }
    }
    Console.WriteLine(sumNegElem);
}

void sumPosElem(int[] arrayPos)
{
    int sumPosElem = 0;
    for (int i = 0; i < arrayPos.Length; i++)
    {
        if (arrayPos[i] > 0)
        {
            sumPosElem += arrayPos[i];
        }
    }
    Console.WriteLine(sumPosElem);
}

int sizeArray = 12;
int minVal1 = -9;
int maxVal1 = 9;
int [] cretArrr = CreateArray(sizeArray, minVal1, maxVal1);
ShowArray(cretArrr);
*/

/*//Задача 2.
//Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

/*int[] RandomArr()
{
    int size = new Random().Next(4, 10);
    int[] randArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        randArr[i] = new Random().Next(-10, 10);
    }
    return randArr;
}

void PrintArr(int[] arrPrint)
{
    for (int i = 0; i < arrPrint.Length; i++)
    {
        Console.Write(arrPrint[i] + "");
    }
    Console.WriteLine();
}

int[] InvArr(int[] invertArr){
for (int i = 0; i < invertArr.Length; i++)
{
    invertArr[i]=invertArr[i] *-1;
 }
 return invertArr;
}
int[] massiv = RandomArr();
PrintArr(massiv);
int[] invertA = InvArr(massiv);
PrintArr(invertA);*/
/*//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент,
 второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21*/
/*int [] startArray = RandomArray();

int size = startArray.Length;

int [] MultyArray(int [] startArray)
{
    int [] temp;
    if (startArray.Length % 2 == 0)
        temp = new int [size/2];
    else 
    {
        temp =  new int [size/2 + 1];
        temp [size/2] = startArray[size/2];
    }
    for (int i = 0; i < size/2; i++)//  7/2 -> 3
        temp[i] = startArray[i] * startArray[startArray.Length - 1 - i];
    return temp;
}
PrintArray(startArray);//метод печати свой
int [] multy = MultyArray(startArray);
PrintArray(multy);//метод печати свой*/
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5