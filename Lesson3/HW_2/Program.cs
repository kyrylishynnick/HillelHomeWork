//Написати програму, яка обчислює квадрат будь-якого введеного числа (бажано використати Math).

Console.WriteLine("Inpur please a number:");
double userInput = double.Parse(Console.ReadLine());

double square = Math.Pow(userInput, 2);
Console.WriteLine($"The square of the number {userInput} is {square}");