Console.Write("Введите число: ");
string? number = Console.ReadLine();

string CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        return $"Ваше число: {number} - палиндром.";
    }
    else
    {
        return $"Ваше число: {number} - НЕ палиндром.";
    }
}

if (number!.Length != 5)
{
    Console.WriteLine("Введите правильное число");
    return;
}

string result = CheckingNumber(number);
Console.WriteLine(result);