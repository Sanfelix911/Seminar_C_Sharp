Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int count = numb * (-1);

while(count <= numb)
{
     Console.Write(count);
     count = count + 1;
}

