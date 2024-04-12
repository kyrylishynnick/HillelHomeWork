// Написати програму, яка обчислює середнє арифметичне двох чисел.

Console.WriteLine("Hello, please enter the first number");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Hello, please enter the second number");
double secondNumber = double.Parse(Console.ReadLine());
double avarageNumber = (firstNumber + secondNumber) / 2;

Console.WriteLine($"The avarage number is: {avarageNumber}");