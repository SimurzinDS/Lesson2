Console.WriteLine("Введите число и нажмите Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число и нажмите Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int a = 0;


if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
}
else
{
    a = firstNumber % secondNumber;
    Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {a}");
}
