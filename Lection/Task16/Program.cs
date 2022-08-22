Console.WriteLine("Введите число и нажмите Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число и нажмите Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int a = firstNumber * firstNumber;
int b = secondNumber * secondNumber;

if(firstNumber == b)
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> да");
}
else
{
    if(secondNumber == a)
    {
         Console.WriteLine($"{firstNumber}, {secondNumber} -> да");
    }
    else
    {
        Console.WriteLine($"{firstNumber}, {secondNumber} -> нет");
    }
}