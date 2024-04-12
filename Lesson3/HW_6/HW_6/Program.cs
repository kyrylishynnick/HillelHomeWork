// Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної та використання суми/множення

Console.WriteLine("Hello, please enter the first number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"The first number before changing is {firstNumber}");
Console.WriteLine("Hello, please enter the second number");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"The second number before changing is {secondNumber}");


firstNumber = firstNumber ^ secondNumber;
secondNumber = firstNumber ^ secondNumber;
firstNumber = firstNumber ^ secondNumber;

Console.WriteLine("________________________________________________");
Console.WriteLine($"The first number after changing: {firstNumber}");
Console.WriteLine($"The first number after changing: {secondNumber}");
