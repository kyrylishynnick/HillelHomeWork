//Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа.
//Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння (чи рівні значення,
//а якщо ні, яке число більше/менше).

Console.WriteLine("Hello, please input the first number");
int firstUserInput = int.Parse(Console.ReadLine());

Console.WriteLine("Hello, please input the second number");
int secondUserInput = int.Parse(Console.ReadLine());
Console.WriteLine($"The first number is: {firstUserInput}. The second  number is: {secondUserInput}");

if (firstUserInput > secondUserInput)
{
    Console.WriteLine("The first value is bigger than second");
}
else if (firstUserInput < secondUserInput)
{
    Console.WriteLine("The second value is bigger than first");
}
else if (firstUserInput == secondUserInput)
{
    Console.WriteLine("The numbers are equal");
}