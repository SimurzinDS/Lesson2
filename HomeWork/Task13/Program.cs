// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645 -> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6



int? thirdNumber(int arg)
{
    if (arg < 100 && arg > -100) // Проверям что число меньше 100 или больше -100 [-99...99], т.е
    {
        return null;
    }
    else
    {
      int result = arg;
      if(result < 0)
      {
        result = result * -1;
      }
      while (result > 1000)
      {
        result = result / 10;
      }
      result = result % 10;
      return result;
    }
}

Console.WriteLine("Введите число");
var input = Convert.ToInt32(Console.ReadLine());

var number = thirdNumber(input);

if(number == null)
{
Console.WriteLine("третьей цифры нет");
}
else
{
Console.WriteLine(number);
}