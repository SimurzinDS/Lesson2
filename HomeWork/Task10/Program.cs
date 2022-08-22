// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int returnSecondNumber(int number)
{
    int result = ((number % 100) / 10);
    return result;
}

Console.WriteLine("Введите трёхзначное число и нажмите Enter");
int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = returnSecondNumber(number);

Console.Write($"{number} -> {secondNumber}");