Random random = new Random();
 // Для генерации рандомных чисел
int randomNumber = random.Next(100,1000); 

Console.WriteLine(randomNumber);

int lastNumber = randomNumber % 10;
int firstNumber = randomNumber / 100;

Console.WriteLine($"{firstNumber}{lastNumber}");
