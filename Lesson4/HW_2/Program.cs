// Написати програму, в якій користувач вводить номер місяця.
// Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»; 9-11 – «Осінь».
// У будь-якому іншому випадку - "Немає такого місяця на цій планеті" .

Console.WriteLine("Hello, please enter the number of month to detect the season");
int userInput = int.Parse(Console.ReadLine());

if (userInput == 1 || userInput == 2 || userInput == 12)
{
    Console.WriteLine("So, today is winter");
}
else if (userInput == 3 || userInput == 4 || userInput == 5)
{
    Console.WriteLine("So, today is autumn");
}
else if (userInput == 6 || userInput == 7 || userInput == 8)
{
    Console.WriteLine("So, today is summer");
}
else if (userInput == 9 || userInput == 10 || userInput == 11)
{
    Console.WriteLine("So, today is spring");
}
else
{
    Console.WriteLine("Sorry, we don't have this month in the world!");
}