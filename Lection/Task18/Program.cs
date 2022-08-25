Console.WriteLine("Введите четверь");

bool isNumber = int.TryParse(Console.ReadLine(), out int x);

if (x<1 || x>4 || isNumber == false)
{
    Console.WriteLine("Неверный ввод");
    return;
}

string result = GetPosition(x);
Console.WriteLine("Диапазон равен "+result);

string GetPosition(int quarter)
{
    string str1;
    if(quarter == 1)
    {
       str1 = "x > 0 | y >0";
       return  str1;
    }

    if(quarter == 2)
    {
       str1 = "x < 0 | y > 0";
       return str1;
    }

    if(quarter == 3)
    {
       str1 = "x < 0 | y < 0";
       return str1;
    }

    if(quarter == 4)
    {
       str1 = "x > 0 | y < 0";
       return str1;
    }
    
    return str1 = "Ошибочка какая-то";
}
