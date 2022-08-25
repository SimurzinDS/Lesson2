Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int x);

if(!isNumber || x<1)
{
    Console.WriteLine("Неверный ввод");
    return;
}


int[] GetSquareArray(int x)
{
    int[] array = new int[x];
    int count = 1;
    while (count <= x)
    {
        array[count-1] = (int)Math.Pow(count, 2);
        count++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(GetSquareArray(x));