// Напишіть програму, яка приймає від користувача число від 1 до 100.
// При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz.
// Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz.
// Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.

Console.WriteLine("Hello, please enter the number between 1 and 100");
int userInput = int.Parse(Console.ReadLine());

if (userInput < 1 || userInput > 100)
{
    Console.WriteLine("Sorry, you inputed wrong number");
}
else if (userInput % 15 == 0)
{
    Console.WriteLine("FizzBuzz");
}
else if (userInput % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (userInput % 5 == 0)
{
    Console.WriteLine("Buzz");
}